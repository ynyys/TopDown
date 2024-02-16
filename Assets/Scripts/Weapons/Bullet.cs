using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Variables
    public float speed;
    public float damage;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.up * speed;

        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Optimisation (Destroying bullets on collison)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<HealthSystem>()!= null)
        {
            HealthSystem _healthSystem = collision.gameObject.GetComponent<HealthSystem>();
            _healthSystem.TakeDamage(damage);
        }
        //Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
