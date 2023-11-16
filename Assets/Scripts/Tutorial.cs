using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public string gameSceneName; // The name of your game scene

    public void ToGame()
    {
        // Load the game scene when the Play button is clicked
        SceneManager.LoadScene(gameSceneName);
    }
}
