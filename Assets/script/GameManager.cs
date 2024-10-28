using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("GameManager is null!");
            }
            return _instance;
        }
    }

    public GameState gameState;

    public static event Action<GameState> OnGameStateChanged;

    public bool HasCard { get; set; }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject); 
    }

    private void Start()
    {
        UpdateGameState(GameState.GameStart);
    }

    public void UpdateGameState(GameState newState)
    {
        gameState = newState; 
        switch (gameState)
        {
            case GameState.GameStart:
                HandleGameStart();
                break;
            case GameState.InGame:
                HandleInGame();
                break;
            case GameState.Win:
                HandleWin();
                break;
            case GameState.Lose:
                HandleLose();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        OnGameStateChanged?.Invoke(newState);
    }
    
    private void HandleGameStart()
    {
        // Logic for starting the game
    }

    private void HandleInGame()
    {
        // Logic for when the game is in progress
    }

    private void HandleWin()
    {
        // Logic for winning the game
    }

    private void HandleLose()
    {
        // Logic for losing the game
    }
}

public enum GameState
{
    GameStart,
    InGame,
    Win,
    Lose
}