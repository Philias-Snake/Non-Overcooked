using System;
using UnityEngine;
using UnityEngine.InputSystem;
using PlayerInput = UnityEngine.InputSystem.PlayerInput;
public class BackEndLocal : MonoBehaviour
{
    //le nombre de joueur dans la game
    public int PlayerNumber;
    
    [Header("Speed")]
    //bool qui verifie si le joueur est a la vitesse normale
    public bool isNormalSp = false;
    //player speed en temps normal
    public int playerSpeed;
    //call du new imput sys
    PlayerInput playerInput;
    //autre new imput sys
    InputAction validateAction;
    //le playercontroller du joueur
    PlayerControllerLocal playerControllerLocal;
    
    void Update()
    {
        // verifie si le joueur est ingame et si il a une vitesse normale
        if (GameManager.Instance.gameState == GameState.InGame && !isNormalSp)
        {
            //tp les joueur a leur spawn point
            transform.position = GameManager.Instance.SpawnPoints[PlayerNumber].transform.position;
            //met la vitesse du joueur a la vitesse normale
            playerControllerLocal.moveSpeed = playerSpeed;
            //set le bool
            isNormalSp = true;
        }

        // verifie si le joueur est dans le menu de debut du jeu
        if (GameManager.Instance.gameState == GameState.GameStart)
        {
            //si le joueur valide/se met pret
            if (validateAction.WasPressedThisFrame())
            {
                //change le bool de ready
                GameManager.Instance.IsReady[PlayerNumber] = !GameManager.Instance.IsReady[PlayerNumber];
            }
        }
    }

    private void Awake()
    {
        //verif si le game state a changé pour debug
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
        // si joueur dabs gamme start on awake
        if (GameManager.Instance.gameState == GameState.GameStart)
        {
            //ajoute le joueur dans la liste des joueur
            GameManager.Instance.Players.Add(gameObject);
            //update le player count
            PlayerNumber = GameManager.Instance.Players.Count - 1;
            //activer le panel ui du joueur
            GameManager.Instance.Panel[PlayerNumber].SetActive(true);
            //get le player component
            playerControllerLocal = GetComponent<PlayerControllerLocal>();
            //mettre la move speed a 0 pour que le joueur ne puisse pas se deplacer dans les menus
            playerControllerLocal.moveSpeed = 0;
            //get component player input (new input sys)
            playerInput = GetComponent<PlayerInput>();
            //init validate action
            validateAction = playerInput.actions.FindAction("Validate"); 
        }
    }
    
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }
    //debug
    private void GameManagerOnGameStateChanged(GameState newState)
    {
        Debug.Log("Game State Changed to: " + newState);
    }
}
