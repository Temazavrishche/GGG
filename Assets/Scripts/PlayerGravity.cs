using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    public LayerMask Mask;
    private bool Grounded;
    public Transform groundCheck;
    Vector3 grav;
    private CharacterController ch;
    private void Start()
    {
        ch = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Grounded = Physics.CheckSphere(groundCheck.position,0.1f,Mask);
        if (!Grounded)
        {
            grav.y += Physics.gravity.y * Time.deltaTime;
            ch.Move(grav * Time.deltaTime);
        }
        else grav.y = 0;
    }
}
