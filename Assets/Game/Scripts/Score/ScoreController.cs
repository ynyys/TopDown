using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    //Variables
    public UnityEvent OnScoreChanged;
    
    public int Score { get; private set; }

    //To add score to the gamne
    public void AddScore(int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke(); 
    }
}
