using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseUI;
    public string sceneMenu;
    public string sceneGame;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseUI.activeSelf)
            {
                pauseUI.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                pauseUI.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void ToggleMenu(GameObject menu, bool isActive)
    {
        menu.SetActive(isActive);
    }
}