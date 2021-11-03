using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeapon : MonoBehaviour
{
    private PlayerSlotsController Slots;
    public List<GameObject> Weapons = new List<GameObject>();
    private Sprite WeaponImage;
    private void Start()
    {
        Slots = GetComponent<PlayerSlotsController>();
    }
    private void Update()
    {
        CheckWeapon();
    }

    public void AddWeapon(string _WeaponName, Sprite _WeaponImage, GameObject _WeaponScript, int index)
    {
        WeaponImage = _WeaponImage;
        GameObject _WeaponName_ = Instantiate(_WeaponScript, transform.position, Quaternion.identity);
        _WeaponName_.transform.SetParent(transform);
        _WeaponName_.name = _WeaponName;
        if (index == 123)
        {
            Weapons.Add(_WeaponName_);
            AddImageWeapon(123);
        }
        else Weapons.Insert(index, _WeaponName_);
    }
    private void CheckWeapon()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Slots.boolSlots[i] && Weapons.Count > i && Weapons[i] != null) Weapons[i].SetActive(true);
            else if (!Slots.boolSlots[i] && Weapons.Count > i && Weapons[i] != null) Weapons[i].SetActive(false);
        }
    }
    public void AddImageWeapon(int _index)
    {
        if (_index == 123)
            Slots.Images[Weapons.Count - 1].sprite = WeaponImage;
        else Slots.Images[_index].sprite = WeaponImage;
    }
}
