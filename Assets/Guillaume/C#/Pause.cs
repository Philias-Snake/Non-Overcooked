using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject pauseUI;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pauseUI.activeSelf)
            {
                ClosePause();
            }
            else
            {
                OpenPause();
            }
        }
    }

    public void OpenPause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePause()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }
}