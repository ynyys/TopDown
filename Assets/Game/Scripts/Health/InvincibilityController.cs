using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    // Variables

    //reference health script
    private HealthController _healthController;

    //Get health controller component
    private void Awake()
    {
        _healthController = GetComponent<HealthController> ();
    }

    //Start invincibility period
    public void StartInvincibility(float invincibilityDuration)
    {
       StartCoroutine(InvincibilityCoroutine(invincibilityDuration)); 
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityDuration)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(invincibilityDuration);
        _healthController.IsInvincible = false;
    }
}
