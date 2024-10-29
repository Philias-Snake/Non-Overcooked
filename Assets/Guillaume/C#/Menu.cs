using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class Menu : MonoBehaviour
{
    public static MenuManager Instance;

    public MenuState State;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateMenuState(MenuState bouttonState)
    {
        State = bouttonState;
        switch (buttonState)
        {
            case MenuState.Play:
                break;
            
            case MenuState.Sounds:
                break;
            
            default:
                throw new ArgumentOutOfRangeException(nameof(buttonState), buttonState, null);
        }
    }

    public enum MenuState
    {
        Play,
        Sounds,
        Quit,
        Yes,
        No,
        Return
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