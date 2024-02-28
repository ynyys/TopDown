using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreValue : MonoBehaviour
{
    // Keep score value
    [SerializeField]
    TMP_Text myScore;
    public void LoadSceneAndKeepValue()
    {
        string dataToKeep = myScore.text;
        StaticData.valueToKeep = dataToKeep;
    }
}
