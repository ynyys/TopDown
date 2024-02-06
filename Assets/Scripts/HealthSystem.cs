using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    //Variables
    public float maxHealth;
    float currentHealth;


    public Image mask;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    //Damage check
    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;
        UpdateHealthBar();

        //Check player is not at 0 health
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void UpdateHealthBar()
    {
        float fill = currentHealth / maxHealth;
        mask.fillAmount = fill;

        if (currentHealth < 0)
        {
            mask.fillAmount = 0;
        }
    }

    //Clear object
    public void Die()
    {
        Destroy(gameObject);
    }
}
