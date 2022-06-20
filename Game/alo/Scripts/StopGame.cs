using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopGame : MonoBehaviour
{
    public GameObject menu;
    private bool stopGame;

    private void Start()
    {
        menu.SetActive(false);
    }

    public void Update()
    {
        if (stopGame && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            stopGame = false;
            menu.SetActive(true);
        }
        else if (!stopGame && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            stopGame = true;
            menu.SetActive(false);
        }
    }

    public void BackToGame()
    {
        Time.timeScale = 1f;
        stopGame = true;
        menu.SetActive(false);
    }

    public void BackToMemu(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}