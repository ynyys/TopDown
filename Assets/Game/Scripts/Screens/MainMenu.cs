using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start game
    public void StartGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    //Load credits
    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    //Quit application
    public void QuitGame()
    {
        Application.Quit();
    }
}
