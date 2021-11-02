using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Minigun : MonoBehaviour
{
    private PlayerInputController input;
    private Animator anim;
    private bool CanShoot = true;
    public float FireRate = 0.25f;
    private PlayerMove PM;
    public GameObject bulletPrefab;
    public GameObject[] FirePoints;
    private void Start()
    {
        FirePoints = new GameObject[8];
        for (int i = 0; i < 8; i++)
        {
            FirePoints[i] = GameObject.FindWithTag("MinigunFirePoint" + i);
        }
        PM = GetComponentInParent<PlayerMove>();
        anim = GetComponentInParent<Animator>();
        input = GetComponentInParent<PlayerInputController>();
    }
    private void Update()
    {
        if (input.fireValue == 1 && CanShoot)
            StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        CanShoot = false;
        anim.SetBool("Shooting",true);
        yield return new WaitForSeconds(1);
        PM.speed /= 2;
        PM.rotation /= 2;
        GetComponentInParent<PlayerSlotsController>().enabled = false;
        while (input.fireValue == 1)
        {
            instBullet(FirePoints[0]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[1]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[2]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[3]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[4]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[5]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[6]);
            yield return new WaitForSeconds(FireRate / 8);
            instBullet(FirePoints[7]);
            yield return new WaitForSeconds(FireRate / 8);
        }
        GetComponentInParent<PlayerSlotsController>().enabled = true;
        if (input.fireValue == 0)
            anim.SetBool("Shooting", false);
        CanShoot = true;
        PM.speed *= 2;
        PM.rotation *= 2;
    }

    private void instBullet(GameObject _firePoint)
    {
       Instantiate(bulletPrefab, _firePoint.transform.position, _firePoint.transform.rotation);
    }
    private void OnDisable()
    {
        anim.SetBool("Shooting", false);
        anim.SetBool("MinigunAim", false);
        CanShoot = true;
    }
}
