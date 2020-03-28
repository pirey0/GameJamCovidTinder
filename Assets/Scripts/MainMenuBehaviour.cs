using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBehaviour : MonoBehaviour
{
    [SerializeField] string _mainSceneName;

    [SerializeField] GameObject _mainPage, _creditsPage, _howToPage;

    public void Play()
    {
        Debug.Log("Play!");
        UnityEngine.SceneManagement.SceneManager.LoadScene(_mainSceneName);
    }

    public void Credits()
    {
        Debug.Log("Credits");

        _mainPage.SetActive(false);
        _creditsPage.SetActive(true);
        _howToPage.SetActive(false);

    }

    public void HowTo()
    {
        Debug.Log("HowTo");

        _mainPage.SetActive(false);
        _creditsPage.SetActive(false);
        _howToPage.SetActive(true);
    }

    public void Back()
    {
        Debug.Log("Back");

        _mainPage.SetActive(true);
        _creditsPage.SetActive(false);
        _howToPage.SetActive(false);
    }

}
