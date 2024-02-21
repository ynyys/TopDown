using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float _currentHealth;

    [SerializeField]
    private float _maximumHealth;

    public float RemainingHealthPercentage
    {
        //Calculting haelth percentage
        get
        {
            return _currentHealth / _maximumHealth;
        }
    }

    //Taking damage
    public void TakeDamage(float damageAmount)
    {
        //If health is zero, do no damage
        if (_currentHealth == 0)
        {
            return;
        }

        //Subtract damage from current health
        _currentHealth -= damageAmount;

        //Change minus values to zero in case that occurs
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }

    //Adding health
    public void AddHealth(float amountToAdd)
    {
        //If full, do nothing
        if (_currentHealth == _maximumHealth) 
        {
            return;
        }

        //Add health
        _currentHealth += amountToAdd;

        //Prevent health from going over maximum
        if (_currentHealth > _maximumHealth)
        {
            _currentHealth = _maximumHealth;
        }
    }
}
