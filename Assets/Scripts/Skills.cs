using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    private  PlayerInputController input;
    public float dashTime = 0.25f, dashPower, DashCooldown, SpearThrow—ooldown, GrapplingHook—ooldown;
    private bool CanDash = true, CanThrow = true, CanGrap = true;
    private CharacterController ch;
    public GameObject SpearPrefab, head, target, GrapplingHookPrefab;

    private void Start()
    {
        input = GetComponent<PlayerInputController>();
        ch = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (input.qAbility == 1 && CanDash)
            StartCoroutine(Dash()); 
        if (input.eAbility == 1 && CanThrow)
            StartCoroutine(SpearThrow());
        if(input.rAbility == 1 && CanGrap)
            StartCoroutine(GrapplingHook());
    }

    IEnumerator Dash()
    {
        CanDash = false;
        float startTime = Time.time;
        while (Time.time < startTime + dashTime)
        {
            ch.Move(transform.forward * dashPower * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(DashCooldown);
        CanDash = true;
    }
    IEnumerator SpearThrow()
    {
        CanThrow = false;
        Vector3 dir = head.transform.position - target.transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Instantiate(SpearPrefab,head.transform.position, Quaternion.Euler(lookRotation.eulerAngles + new Vector3(-90,0,0)));
        yield return new WaitForSeconds(SpearThrow—ooldown);
        CanThrow = true;
    }
    IEnumerator GrapplingHook()
    {
        CanGrap = false;
        Instantiate(GrapplingHookPrefab, head.transform.position,Camera.main.transform.rotation);
        yield return new WaitForSeconds(GrapplingHook—ooldown);
        CanGrap = true;
    }
}
