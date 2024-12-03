using Mirror.BouncyCastle.Crypto.Generators;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string sceneName;

    public void PlayButton()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OkButton()
    {
        Application.Quit();
    }

    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    public void CloseMenu(GameObject close)
    {
        close.SetActive(false);
    }
}