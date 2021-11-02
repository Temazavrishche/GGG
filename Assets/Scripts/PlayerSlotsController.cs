using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerSlotsController : MonoBehaviour
{
    private PlayerInputController input;
    private PlayerWeapon Weapon;
    public GameObject BulletPrefab;
    public bool[] boolSlots;
    public Image[] Images;
    public GameObject CurrentWeapon;
    private void Start()
    {
        input = GetComponent<PlayerInputController>();
        Weapon = GetComponent<PlayerWeapon>();
    }

    private void Update()
    {
        if(input.Slots[0] == 1 && !boolSlots[0])
        {
            SetSlot(0);
        }
        if (input.Slots[1] == 1 && !boolSlots[1])
        {
            SetSlot(1);
        }
        if (input.Slots[2] == 1 && !boolSlots[2])
        {
            SetSlot(2);
        }
        if (input.Slots[3] == 1 && !boolSlots[3])
        {
            SetSlot(3);
        }
        if (input.Slots[4] == 1 && !boolSlots[4])
        {
            SetSlot(4);
        }
        if (input.HideTheWeapon == 1)
        {
            SetSlot(5);
        }
    }

    private void SetSlot(int _slot)
    {
        for (int i = 0; i < 5; i++)
        {
            input.Slots[i] = 0;
            boolSlots[i] = false;
            Images[i].color = Color.white;
            CurrentWeapon = null;
        }
        if(_slot != 5)
        {
            input.Slots[_slot] = 1;
            boolSlots[_slot] = true;
            Images[_slot].color = Color.green;
            if(Weapon.Weapons.Count > _slot && Weapon.Weapons[_slot] != null)
                CurrentWeapon = Weapon.Weapons[_slot];
        }
    }
}
