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
    public MouseCursorInvisible Mouseinvisible;

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
        Mouseinvisible.MouseUnlocked();
        PauseUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void ResumeGame()
    {
        Mouseinvisible.MouseLocked();
        PauseUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    public void ExitGame() // If click Exit button, Game application will be exit
    {
        Application.Quit();
        
    }

    public void BacktoMainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TooltipScene");
    }


    public void Defeat()
    {
        Mouseinvisible.MouseUnlocked();
        Time.timeScale = 0;
        defeat.SetActive(true);
        
    }

    public void Completed()
    {
        Mouseinvisible.MouseUnlocked();
        Time.timeScale = 0;
        Complete.SetActive(true);
    }

}

