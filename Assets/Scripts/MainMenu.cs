using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Making Mainmenu click functions
    ///
    /// </summary>
    public void StartScene() // If click Start button, Load Scene will be load)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame() // If click Exit button, Game application will be exit
    {
        Application.Quit();
        Debug.Log("Exit");
    }

}
