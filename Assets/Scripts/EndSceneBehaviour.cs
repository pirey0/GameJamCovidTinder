using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneBehaviour : MonoBehaviour
{

    [SerializeField] Text _scoreText, _highScoreText;

    [SerializeField] string _mainMenuSceneName, _gameSceneName;

    void Start()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            _scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        }

        if (PlayerPrefs.HasKey("HighScore"))
        {
            _highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

    public void LoadMainMenu()
    {
        Debug.Log("Main Menu");

        UnityEngine.SceneManagement.SceneManager.LoadScene(_mainMenuSceneName);
    }

    public void LoadGameScene()
    {
        Debug.Log("Game Scene");

        UnityEngine.SceneManagement.SceneManager.LoadScene(_gameSceneName);

    }

    
   
}
