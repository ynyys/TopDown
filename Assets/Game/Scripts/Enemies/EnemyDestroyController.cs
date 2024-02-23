using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyController : MonoBehaviour
{
    // Variables
    
    public void DestroyEnemy(float delay)
    {
        Destroy(gameObject, delay);
    }
}
