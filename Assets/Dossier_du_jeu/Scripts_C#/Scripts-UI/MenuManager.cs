using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string sceneGame;

    public void PlayButton()
    {
        SceneManager.LoadScene(sceneGame);
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