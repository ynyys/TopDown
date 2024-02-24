using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    //Variables
    [SerializeField]
    private int _killScore;

    //Linking score controller script
    private ScoreController _scoreController;

    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreController>();
    }

    //Adding score
    public void AllocateScore()
    {
        _scoreController.AddScore(_killScore);
    }
}
