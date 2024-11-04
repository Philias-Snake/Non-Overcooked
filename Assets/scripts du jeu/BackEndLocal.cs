using System;
using UnityEngine;
using UnityEngine.InputSystem;
using PlayerInput = UnityEngine.InputSystem.PlayerInput;
//TODO: faire les commentaires
public class BackEndLocal : MonoBehaviour
{
    public int PlayerNumber;
    public bool isNormalSp = false;
    PlayerInput playerInput;
    InputAction validateAction;
    PlayerControllerLocal playerControllerLocal;
    
    void Update()
    {
        if (GameManager.Instance.gameState == GameState.InGame && !isNormalSp)
        {
            transform.position = GameManager.Instance.SpawnPoints[PlayerNumber].transform.position;
            playerControllerLocal.moveSpeed = 50;
            isNormalSp = true;
        }

        if (GameManager.Instance.gameState == GameState.GameStart)
        {
            if (GameManager.Instance.gameState == GameState.GameStart)
            {
                if (validateAction.WasPressedThisFrame())
                {
                    GameManager.Instance.IsReady[PlayerNumber] = !GameManager.Instance.IsReady[PlayerNumber];
                }
            }
        }
    }

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
        
        if (GameManager.Instance.gameState == GameState.GameStart)
        {
            GameManager.Instance.Players.Add(gameObject);
            PlayerNumber = GameManager.Instance.Players.Count - 1;
            GameManager.Instance.Panel[PlayerNumber].SetActive(true);
            playerControllerLocal = GetComponent<PlayerControllerLocal>();
            playerControllerLocal.moveSpeed = 0;
            playerInput = GetComponent<PlayerInput>();
            validateAction = playerInput.actions.FindAction("Validate"); 
        }
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }

    private void GameManagerOnGameStateChanged(GameState newState)
    {
        Debug.Log("Game State Changed to: " + newState);
    }
}