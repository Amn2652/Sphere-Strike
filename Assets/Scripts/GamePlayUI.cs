using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUI : MonoBehaviour
{
    public GameObject pausePanal;

    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanal.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanal.SetActive(false);

    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        
    }

}
