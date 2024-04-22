using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenuPanal;
    public GameObject optionPanal;
    public GameObject guidePanal;
    public GameObject highscorePanal;
    public GameObject aboutUsPanal;
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        mainMenuPanal.SetActive(true);
        optionPanal.SetActive(false);
        guidePanal.SetActive(false);
        highscorePanal.SetActive(false);
        aboutUsPanal.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOption()
    {
        mainMenuPanal.SetActive(false);
        optionPanal.SetActive(true);
    }

    public void back()
    {
        mainMenuPanal.SetActive(false);
        optionPanal.SetActive(true);
        guidePanal.SetActive(false);
        highscorePanal.SetActive(false);
        aboutUsPanal.SetActive(false);
    }

    public void OpenGuide()
    {
        mainMenuPanal.SetActive(false);
        guidePanal.SetActive(true);
    }

    public void OpenHighscore()
    {
        highScoreText.text = PlayerPrefs.GetInt("highscore").ToString();
        mainMenuPanal.SetActive(false);
        highscorePanal.SetActive(true);
    }

    public void OpenAboutUs()
    {
        mainMenuPanal.SetActive(false);
        aboutUsPanal.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void optionBack()
    {
        mainMenuPanal.SetActive(true);
        optionPanal.SetActive(false);
    }
}
