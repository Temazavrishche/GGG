using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class MinigunBullet : MonoBehaviour
{
    public string[] tagsToChek;
    private Rigidbody rb;
    public float damage,LifeTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.position = transform.position + transform.forward * 40 * Time.deltaTime;
        LifeTime -= Time.deltaTime;
        if (LifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
        if (tagsToChek.Contains(other.tag))
            Destroy(gameObject);
    }
}
