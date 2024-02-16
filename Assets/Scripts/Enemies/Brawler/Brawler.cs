using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brawler : MonoBehaviour
{
    public float damage=2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HealthSystem>() != null)
        {
            HealthSystem _healthSystem = collision.gameObject.GetComponent<HealthSystem>();
            _healthSystem.TakeDamage(damage);
        }

    }
}
