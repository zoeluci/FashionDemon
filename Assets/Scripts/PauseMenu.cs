using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject pausePanel;
    public bool pauseOn;

    public void Play()
    {
        pauseOn = !pauseOn;
        Time.timeScale = 1;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseOn = !pauseOn;
            pausePanel.SetActive(pauseOn);

            if (!pauseOn)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }
    }
}
