using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
