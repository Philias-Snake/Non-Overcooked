//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using System.Linq;
//using System;
//
//public class MenuManager : MonoBehaviour
//{
//    public static MenuManager Instance;
//
//    public MenuState State;
//
//    void Awake()
//    {
//        Instance = this;
//    }
//
//    public void UpdateMenuState(MenuState bouttonState)
//    {
//        State = bouttonState;
//        switch (buttonState)
//        {
//            case MenuState.Play:
//                PlayGame();
//                break;
//            case MenuState.Sounds:
//                PlaySoundOption();
//                break;
//            case MenuState.Quit:
//                PlayQuit();
//                break;
//            case MenuState.Yes:
//                ResponseYes();
//                break;
//            case MenuState.No:
//                ResponseNo();
//                    break;
//            case MenuState.Return:
//                PlayReturn();
//                break;
//            default:
//                throw new ArgumentOutOfRangeException(nameof(buttonState), buttonState, null);
//        }
//    }
//
//    private void PlayGame()
//    {
//
//    }
//
//    private void PlaySoundOption()
//    {
//
//    }
//
//    private void PlayQuit()
//    {
//
//    }
//
//    private void ResponseYes()
//    {
//
//    }
//
//    private void ResponseNo()
//    {
//
//    }
//
//    private void PlayReturn()
//    {
//
//    }
//
//    public enum MenuState
//    {
//        Play,
//        Sounds,
//        Quit,
//        Yes,
//        No,
//        Return
//    }
//
//    /// <summary>
//    /// Appel la sc�ne JujiLocal.
//    /// </summary>
//    public void Play()
//    {
//        SceneManager.LoadScene("JujiLocal");
//        Time.timeScale = 1f;
//    }
//
//    /// <summary>
//    /// Ouvre le menu.
//    /// </summary>
//    public void OpenMenu(GameObject open)
//    {
//        open.SetActive(true);
//        ButtonPlay.SetActive(false);
//    }
//
//    /// <summary>
//    /// Ferme le menu.
//    /// </summary>
//    public void CloseMenu(GameObject close)
//    {
//        close.SetActive(true);
//    }
//
//    /// <summary>
//    /// Ferme le jeu.
//    /// </summary>
//    public void Quit()
//    {
//        Application.Quit();
//    }
//}