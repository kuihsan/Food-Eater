using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishToMenu : MonoBehaviour
{
    public string gameSceneName; // The name of your game scene

    public void ToMenu()
    {
        // Load the game scene when the Play button is clicked
        SceneManager.LoadScene(gameSceneName);
    }
}
