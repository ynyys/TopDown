using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour
{
    // Variables

    private void OnCollisionEnter2D(Collision2D collision) 
    { 
        //Enemies take damage
        if(collision.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth enemyHealthComponent))
        {
            enemyHealthComponent.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
