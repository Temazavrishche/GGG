using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastArcLightning : MonoBehaviour
{
    private PlayerInputController input;
    private bool CanCast = true;
    public GameObject ArcLightningPrefab, head, target;
    public float ArcLightningCooldown;
    private void Start()
    {
        input = GetComponentInParent<PlayerInputController>();
        head = GameObject.FindGameObjectWithTag("Head");
        target = GameObject.FindGameObjectWithTag("Target");
    }
    private void Update()
    {
        if (input.fireValue == 1 && CanCast)
            StartCoroutine(Cast());
    }
    IEnumerator Cast()
    {
        CanCast = false;
        Instantiate(ArcLightningPrefab, head.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(ArcLightningCooldown);
        CanCast = true;
    }
    private void OnDisable()
    {
        CanCast = true;
    }
}
