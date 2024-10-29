using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class Menu : MonoBehaviour
{
    public ButtonState buttonState;

    public static event Action<ButtonState> OnButtonStateChanged;

    public void UpdateButtonState()
    {
        switch ()
        {
            case ButtonState.ButtonPlay
        }
    }


    /// <summary>
    /// Appel la scène JujiLocal.
    /// </summary>
    public void Play()
    {
        SceneManager.LoadScene("JujiLocal");
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Ouvre le menu.
    /// </summary>
    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
        ButtonPlay.SetActive(false);
    }

    /// <summary>
    /// Ferme le menu.
    /// </summary>
    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }

    /// <summary>
    /// Ferme le jeu.
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}