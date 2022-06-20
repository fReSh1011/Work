using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScenes : MonoBehaviour
{
    public GameObject[] menu;

    public Toggle toggle;
    [SerializeField] public static bool onScreen;

    public GameObject loadingScreen;
    private int sceneNumber;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    public void NextScene(int _sceneNumber)
    {
        sceneNumber = _sceneNumber;
        menu[0].SetActive(false);
        menu[1].SetActive(false);
        menu[2].SetActive(false);
        menu[3].SetActive(false);

        if (_sceneNumber == 101)
        {
            menu[1].SetActive(true);
        }
        else if (_sceneNumber == 102)
        {
            menu[2].SetActive(true);
        }
        else if (_sceneNumber == 103)
        {
            menu[3].SetActive(true);
        }
        else if (_sceneNumber == 104)
        {
            menu[4].SetActive(true);
        }
        else
        {
            Load();
            SceneManager.LoadScene(_sceneNumber);
        }
    }

    public void VK(string id)
    {
        Application.OpenURL("https://vk.com/" + id);
    }

    public void Discord(string id)
    {
        Application.OpenURL("https://discord.gg/" + id);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Load()
    {
        loadingScreen.SetActive(true);
        StartCoroutine(LoadAsync());
    }

    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
        onScreen = Screen.fullScreen;
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneNumber);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
