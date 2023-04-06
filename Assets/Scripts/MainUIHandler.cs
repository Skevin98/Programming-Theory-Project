using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField]
    private bool isPaused;

    [SerializeField]
    Text pauseButtonText;


    public void PauseGame()
    {
        if (!isPaused)
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseButtonText.text = "Resume";
        }
        else
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseButtonText.text = "Pause";
        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }
}
