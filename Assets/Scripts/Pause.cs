using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject PauseUI;
    public GameObject defeat;
    public GameObject Complete;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
          
        }
    }

    public void PauseGame()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void ResumeGame()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    public void ExitGame() // If click Exit button, Game application will be exit
    {
        Application.Quit();
        Debug.Log("Exit");
    }

    public void BacktoMainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TooltipScene");
    }


    public void Defeat()
    {
        Time.timeScale = 0;
        defeat.SetActive(true);
        
    }

    public void Completed()
    {
        Time.timeScale = 0;
        Complete.SetActive(true);
    }

}

