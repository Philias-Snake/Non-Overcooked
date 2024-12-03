using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private string sceneMenu;
    [SerializeField] private string sceneGame;

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

    public void OpenMenu(GameObject open)
    {
        open.SetActive(true);
    }

    public void CloseMenu(GameObject close)
    {
        close.SetActive(true);
    }
}