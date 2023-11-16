using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGamePaused = false;

    void Update()
    {
        if (isGamePaused)
        {
            // Pause the game by setting the time scale to 0
            Time.timeScale = 0;
            GetComponent<Player>().moveSpeed = 0;
            
        }
        else
        {
            // Unpause the game by setting the time scale back to 1
            Time.timeScale = 1;
        }
    }

    public void PauseGame()
    {
        isGamePaused = true;
    }

    public void UnpauseGame()
    {
        isGamePaused = false;
    }
}

