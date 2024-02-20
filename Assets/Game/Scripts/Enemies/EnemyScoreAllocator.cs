using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    //Variables
    [SerializeField]
    private int _killScore;

    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindAnyObjectByType<ScoreController>();
    }

    public void AllocateSource()
    {
        _scoreController.AddScore(_killScore);
    }
}
