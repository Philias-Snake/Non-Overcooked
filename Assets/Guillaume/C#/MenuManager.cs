using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System;

public class MenuManager : MonoBehaviour
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
        switch (bouttonState)
        {
            case MenuState.Play:
                PlayGame();
                break;
            case MenuState.Sounds:
                PlaySoundOption();
                break;
            case MenuState.Quit:
                PlayQuit();
                break;
            case MenuState.Yes:
                ResponseYes();
                break;
            case MenuState.No:
                ResponseNo();
                    break;
            case MenuState.Return:
                PlayReturn();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(bouttonState), bouttonState, null);
        }
    }

    private void PlayGame()
    {

    }

    private void PlaySoundOption()
    {

    }

    private void PlayQuit()
    {

    }

    private void ResponseYes()
    {

    }

    private void ResponseNo()
    {

    }

    private void PlayReturn()
    {

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
}