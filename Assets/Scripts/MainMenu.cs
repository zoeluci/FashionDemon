using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool pauseOn;

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
