using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    // Variables
    [SerializeField]
    private float _invincibilityDuration;

    private InvincibilityController _invincibilityController;

    private void Awake()
    {
        _invincibilityController = GetComponent<InvincibilityController>();
    }
    //Begin invincibility period
    public void StartInvincibility()
    {
        _invincibilityController.StartInvincibility(_invincibilityDuration);
    }
}
