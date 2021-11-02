using UnityEngine.InputSystem;
using UnityEngine;
[RequireComponent(typeof(PlayerInput))]
public class PlayerInputController : MonoBehaviour
{
    public Vector2 _look, _move;
    public float aimValue, fireValue, qAbility, eAbility, jump, rAbility, fAbility, HideTheWeapon;
    public float[] Slots; 
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void OnUseqAbility(InputValue value)
    {
        qAbility = value.Get<float>();
    }
    public void OnUseeAbility(InputValue value)
    {
        eAbility = value.Get<float>();
    }
    public void OnUserAbility(InputValue value)
    {
        rAbility = value.Get<float>();
    }
    public void OnUsefAbility(InputValue value)
    {
        fAbility = value.Get<float>();
    }
    public void OnJump(InputValue value)
    {
        jump = value.Get<float>();
    }
    public void OnLook(InputValue value)
    {
        _look = value.Get<Vector2>();
    }
    public void OnMove(InputValue value)
    {
        _move = value.Get<Vector2>();
    }
    public void OnAim(InputValue value)
    {
        aimValue = value.Get<float>();
    }
    public void OnFire(InputValue value)
    {
        fireValue = value.Get<float>();
    }
    public void OnSelectFirstSlot(InputValue value)
    {
        Slots[0] = value.Get<float>();
    }
    public void OnSelectSecondSlot(InputValue value)
    {
        Slots[1] = value.Get<float>();
    }
    public void OnSelectThirdSlot(InputValue value)
    {
        Slots[2] = value.Get<float>();
    }
    public void OnSelectFourthSlot(InputValue value)
    {
        Slots[3] = value.Get<float>();
    }
    public void OnSelectFifthSlot(InputValue value)
    {
        Slots[4] = value.Get<float>();
    }
    public void OnHideTheWeapon(InputValue value)
    {
        HideTheWeapon = value.Get<float>();
    }
}
