using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Variables

    //When other collider toucher collider
    private ICollectableBehaviour _collectableBehaviour;

    private void Awake()
    {
        _collectableBehaviour = GetComponent<ICollectableBehaviour>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check if player intracts with pickup
        var player = collision.GetComponent<PlayerMovement>();

        if (player != null)
        {
            _collectableBehaviour.OnCollected(player.gameObject);
            Destroy(gameObject);
        }
    }
}
