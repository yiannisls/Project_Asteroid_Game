using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); // Get active level and increase it by 1

    }
   public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
   
}
