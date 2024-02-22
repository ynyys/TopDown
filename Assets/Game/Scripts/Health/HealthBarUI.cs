using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthBarUI : MonoBehaviour
{
    // Variables
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForegroundImage;

    //Updating health bar image
    public void UpdateHealthBar(HealthController healthController)
    {
        _healthBarForegroundImage.fillAmount = healthController.RemainingHealthPercentage;
    }
}
