using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //Variables
    [SerializeField]
    float health, maxHealth = 3f;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (float damageAmount)
    {
        health -= maxHealth;

        if (health <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
