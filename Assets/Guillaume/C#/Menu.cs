using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    /// <summary>
    /// 
    /// </summary>
    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    /// <summary>
    /// 
    /// </summary>
    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }

    /// <summary>
    /// 
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
