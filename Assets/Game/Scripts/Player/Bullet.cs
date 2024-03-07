using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float _damageAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the bullet comes into contact with an enemy
        if (collision.GetComponent<EnemyMovement>())
        {
            //Get health controller script
            var healthController = collision.gameObject.GetComponent<HealthController>();
            //Subtract damage amount from health
            healthController.TakeDamage(_damageAmount);
        }
        //When bullet collides with any object in the world
        Destroy(gameObject);
    }
}