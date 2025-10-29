using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Button again;
    public Button quit;

    private void Start()
    {
        again.onClick.AddListener(() => LoadPreviousScene());
        quit.onClick.AddListener(() => QuitGame());
    }

    private void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
