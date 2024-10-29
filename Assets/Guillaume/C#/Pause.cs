using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    /// <summary>
    /// Rend public la demande de l'UI de la pause.
    /// </summary>
    public GameObject pauseUI;

    /// <summary>
    /// ouvre ou ferme la pause grâce au bouton assigner.
    /// </summary>
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

    /// <summary>
    /// Commande permettant d'ouvrir la pause et met le jeu en pause.
    /// </summary>
    public void OpenPause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    /// <summary>
    /// Commande permettant de fermer la pause et remet le jeu en route.
    /// </summary>
    public void ClosePause()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    /// <summary>
    /// Ouvre un menu.
    /// </summary>
    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    /// <summary>
    /// Ferme le menu.
    /// </summary>
    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }

    /// <summary>
    /// Appel la scène Menu.
    /// </summary>
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}