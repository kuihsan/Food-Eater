using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName; // The name of your game scene

    public void PlayGame()
    {
        // Load the game scene when the Play button is clicked
        SceneManager.LoadScene(gameSceneName);
    }
    public void Quit()
    {
        Debug.Log("quitttttt");
        Application.Quit();
    }
}
