using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthCollectableBehaviour : MonoBehaviour, ICollectableBehaviour
{
    // Variables
    [SerializeField]
    private float _healthAmount;

    //WOn the pickup of the item
    public UnityEvent OnPickup;

    //Adding health to the player
    public void OnCollected(GameObject player)
    {
        player.GetComponent<HealthController>().AddHealth(_healthAmount);
    }

}
