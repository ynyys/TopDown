using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float _currentHealth;

    [SerializeField]
    private float _maximumHealth;
    public HealthbarBehaviour Healthbar;

    public float RemainingHealthPercentage

    {
        //Calculting health percentage
        get
        {
            return _currentHealth / _maximumHealth;
        }
    }

    //Allow player to be invincible for every frame taken damage
    public bool IsInvincible { get; set; }

    //When health reaches zero
    public UnityEvent OnDied;

    //Enable invinibility on damage
    public UnityEvent OnDamaged;

    //When health is changed
    public UnityEvent OnHealthChanged;
    public void Start()
    {
        Healthbar.SetHealth(_currentHealth, _maximumHealth);
    }
    //Taking damage
    public void TakeDamage(float damageAmount)
    {
        //If health is zero, do no damage
        if (_currentHealth == 0)
        {
            return;
        }

        if (IsInvincible)
        {
            return;
        }

        //Subtract damage from current health
        _currentHealth -= damageAmount;

        OnHealthChanged.Invoke();

        //Change minus values to zero in case that occurs
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }

        //If health is zero, tell unity player is dead
        if (_currentHealth == 0)
        {
            OnDied.Invoke();
        }
        else
        {
            OnDamaged.Invoke();
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

        OnHealthChanged.Invoke();

        //Prevent health from going over maximum
        if (_currentHealth > _maximumHealth)
        {
            _currentHealth = _maximumHealth;
        }
    }
}
