using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
