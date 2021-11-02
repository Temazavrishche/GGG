using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumGrenadeThrow : MonoBehaviour
{
    private PlayerInputController input;
    private bool CanThrow = true;
    public GameObject GrenadePrefab, head, target;
    public float GrenadeThrowCooldawn;
    private void Start()
    {
        input = GetComponentInParent<PlayerInputController>();
        head = GameObject.FindGameObjectWithTag("Head");
        target = GameObject.FindGameObjectWithTag("Target");
    }
    private void Update()
    {
        if (input.fireValue == 1 && CanThrow)
            StartCoroutine(Throw());
    }

    IEnumerator Throw()
    {
        CanThrow = false;
        Vector3 dir = head.transform.position - target.transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Instantiate(GrenadePrefab, head.transform.position, Quaternion.Euler(lookRotation.eulerAngles + new Vector3(180,0,0)));
        yield return new WaitForSeconds(GrenadeThrowCooldawn);
        CanThrow = true;
    }
    private void OnDisable()
    {
        CanThrow = true;
    }
}
