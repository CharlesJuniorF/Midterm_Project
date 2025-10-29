using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button start;
    public Button quit;

    private void Start()
    {
        start.onClick.AddListener(() => LoadNextScene());
        quit.onClick.AddListener(() => QuitGame());
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
