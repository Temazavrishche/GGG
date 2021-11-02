using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimController : MonoBehaviour
{
    private  PlayerInputController input;
    private PlayerSlotsController Slots;
    public GameObject MainCamera, AimCamera, Crosshair,scope,MinigunAimCamera;
    private Animator anim;
    private PlayerMove PM;

    private void Start()
    {
        Slots = GetComponent<PlayerSlotsController>();
        input = GetComponent<PlayerInputController>();
        anim = GetComponent<Animator>();
        PM = GetComponent<PlayerMove>();
    }

    private void Update()
    {
        if(input.aimValue == 1)
        {
            if(Slots.CurrentWeapon == null)
            {
                MainCamera.SetActive(false);
                AimCamera.SetActive(true);
                anim.SetBool("AimWithoutWeapon",true);
                StartCoroutine(ShowCrosshair(true));
                return;
            }
            switch (Slots.CurrentWeapon.tag)
            {
                case "Minigun":
                    anim.SetBool("MinigunAim", true);
                    MinigunAimCamera.SetActive(true);
                    MainCamera.SetActive(false);
                    StartCoroutine(ShowCrosshair(true));
                    break;
            }
        }
        if (input.aimValue != 1 && !MainCamera.activeSelf)
        {
            if(Slots.CurrentWeapon == null)
            {
                MainCamera.SetActive(true);
                AimCamera.SetActive(false);
                anim.SetBool("AimWithoutWeapon", false);
                StartCoroutine(ShowCrosshair(false));
                return;
            }
            switch (Slots.CurrentWeapon.tag)
            {
                case "Minigun":
                    anim.SetBool("MinigunAim", false);
                    MinigunAimCamera.SetActive(false);
                    MainCamera.SetActive(true);
                    StartCoroutine(ShowCrosshair(false));
                    break;
            }
        }
    }

    IEnumerator ShowCrosshair(bool ChangeBool)
    {
        yield return new WaitForSeconds(0.5f);
        Crosshair.SetActive(ChangeBool);
    }
}
