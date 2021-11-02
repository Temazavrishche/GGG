using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ScriptableObjects", menuName = "ScriptableObjets/Weapon")]
public class WeaponScriptableObject : ScriptableObject
{
    public string WeaponName;
    public Sprite WeaponImage;
    public GameObject WeaponScript;
}
