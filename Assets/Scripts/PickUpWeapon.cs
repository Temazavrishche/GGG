using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpWeapon : MonoBehaviour
{
    private PlayerInputController input;
    public GameObject UIWeaponPickup;
    private PlayerWeapon Weapon;
    private float TimeToDestroy = 0;
    private bool addWeapon = false;
    public Image SwitchWeaponImage;
    public GameObject SwitchWeaponPanel;
    public WeaponScriptableObject WeaponScriptableObject;
    private void Start()
    {
        UIWeaponPickup = GameObject.FindWithTag("UIWeaponPickup");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UIWeaponPickup.gameObject.SetActive(true);
            UIWeaponPickup.gameObject.transform.position = transform.position + Vector3.up * 2;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Weapon = other.GetComponent<PlayerWeapon>();
            input = other.GetComponent<PlayerInputController>();
            if (input.fAbility == 1)
            {
                TimeToDestroy += Time.deltaTime;
            }
            if (input.fAbility == 0 && TimeToDestroy != 0)
            {
                if (TimeToDestroy >= 1.5f)
                    Destroy(gameObject);
                else
                {
                    if (Weapon.Weapons.Count < 5 && !addWeapon)
                    {
                        addWeapon = true;
                        Weapon.AddWeapon(WeaponScriptableObject.WeaponName, WeaponScriptableObject.WeaponImage, WeaponScriptableObject.WeaponScript, 123);
                        Destroy(gameObject);
                    }
                    else if (Weapon.Weapons.Count >= 5 && !addWeapon)
                    {
                        addWeapon = true;
                        SwitchWeaponPanel.SetActive(true);
                        StartCoroutine(Enable(other.gameObject, false));
                    }
                }
            }
            if (input.eAbility == 1 && SwitchWeaponPanel.activeInHierarchy)
            {
                int number = ThatSlotActive();
                if (number == 123)
                {
                    Debug.Log("Не выбрано оружие");
                    return;
                }
                Destroy(Weapon.Weapons[number].gameObject);
                Weapon.Weapons.RemoveAt(number);
                StartCoroutine(Enable(other.gameObject, true));
                Weapon.AddWeapon(WeaponScriptableObject.WeaponName, WeaponScriptableObject.WeaponImage, WeaponScriptableObject.WeaponScript, number);
                Weapon.AddImageWeapon(number);
                SwitchWeaponPanel.SetActive(false);
            }
            else if (input.rAbility == 1 && SwitchWeaponPanel.activeInHierarchy)
            {
                TimeToDestroy = 0;
                addWeapon = false;
                SwitchWeaponPanel.SetActive(false);
                StartCoroutine(Enable(other.gameObject, true));
                return;
            }
        }
    }
    private int ThatSlotActive()
    {
        int Index = 123;
        for (int i = 0; i < 5; i++)
        {
            if (input.Slots[i].Equals(1))
            {
                Index = i;
            }
        }
        return Index;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UIWeaponPickup.gameObject.SetActive(false);
            TimeToDestroy = 0;
            if (SwitchWeaponPanel.activeSelf == true)
            {
                SwitchWeaponPanel.SetActive(false);
            }
        }
    }
    IEnumerator Enable(GameObject obj, bool ChangeBool)
    {
        if (ChangeBool == true && input.eAbility == 1)
        {
            yield return new WaitForSeconds(0.1f);
            obj.GetComponent<PlayerMove>().enabled = ChangeBool;
            obj.GetComponent<Skills>().enabled = ChangeBool;
            obj.GetComponent<PlayerAimController>().enabled = ChangeBool;
            Destroy(gameObject);
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            obj.GetComponent<PlayerMove>().enabled = ChangeBool;
            obj.GetComponent<Skills>().enabled = ChangeBool;
            obj.GetComponent<PlayerAimController>().enabled = ChangeBool;
        }
    }
}
