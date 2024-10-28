using System;
using UnityEngine;

public class BackEndLocal : MonoBehaviour
{
    private void Start()
    {
        // Initialization logic if needed
    }

    private void Update()
    {
        if (GameManager.Instance.gameState == GameState.GameStart)
        {
            // Add relevant logic for GameStart state here
        }
    }

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
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