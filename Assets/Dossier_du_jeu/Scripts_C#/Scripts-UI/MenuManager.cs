using UnityEngine;
public static class MenuManager
{
    public static bool IsInitialised { get; private set; }
    public static GameObject menuMenu, soundMenu, quitMenu;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        menuMenu = canvas.transform.Find("MenuMenu").gameObject;
        soundMenu = canvas.transform.Find("SoundMenu").gameObject;
        quitMenu = canvas.transform.Find("QuitMenu").gameObject;

        IsInitialised = true;
    }


    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInitialised)
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