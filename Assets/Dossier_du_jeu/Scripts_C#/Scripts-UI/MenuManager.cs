using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance { get; private set; }
    public static GameObject menuMenu, soundMenu, quitMenu;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        menuMenu = canvas.transform.Find("MenuMenu").gameObject;
        soundMenu = canvas.transform.Find("SoundMenu").gameObject;
        quitMenu = canvas.transform.Find("QuitMenu").gameObject;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!menuMenu || !soundMenu || !quitMenu)
            Init();

        switch (menu)
        {
            case Menu.MENU:
                menuMenu.SetActive(true);
                break;
                
            case Menu.SOUND:
                soundMenu.SetActive(true);
                break;
                
            case Menu.QUIT:
                quitMenu.SetActive(true);
                break;
        }

        callingMenu.SetActive(false);
    }
}