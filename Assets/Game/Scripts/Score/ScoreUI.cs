using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    // Variables
    private TMP_Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }

    // Update score number
    public void UpdateScore(ScoreController scoreController)
    {
        _scoreText.text = $"Score: {scoreController.Score}";
    }
}
