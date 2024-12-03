using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//TODO: faire les commentaires

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [Header("Player Settings")]
    //liste des joueurs dans la game
    public List<GameObject> Players = new List<GameObject>();
    //est ce que le joueur est ready par default sur faux
    public bool[] IsReady = { false, false, false, false };
    //les points de spawn des joueurs
    public GameObject[] SpawnPoints;
    //les ui relieés au joueurs
    public GameObject[] Panel;
    //le canvas de start du jeu
    [Header("Game settings")]
    public GameObject CanvasGameStart;
    // init game manager instance 
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
    //init game state
    public GameState gameState;

    public static event Action<GameState> OnGameStateChanged;

    //not importent
    public bool HasCard { get; set; }

    private void Update()
    {
        if (IsReady.All(c => c == true))
        {
            UpdateGameState(GameState.InGame);
        }

    }
    //set le dont destroy on load pour continuer a avoir meme si changement de scene
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

    //est appelé en cas de changement de game state
    public void UpdateGameState(GameState newState)
    {
        gameState = newState; 
        //gere le lencement de logique en fonction du nouveau game state
        switch (gameState)
        {
            case GameState.GameStart:
                HandleGameStart();
                break;
            case GameState.InGame:
                CanvasGameStart.SetActive(false );
                HandleInGame();
                break;
            case GameState.Win:
                HandleWin();
                break;
            case GameState.Lose:
                HandleLose();
                break;
            case GameState.Pause:
                HandlePause();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        //trigger l'action OnGameStateChanged
        OnGameStateChanged?.Invoke(newState);
    }
    //ca fait quoi dans ce game state
    private void HandleGameStart()
    {
        Debug.Log("Game Start");
    }

    private void HandleInGame()
    {
        // Logic for when the game is in progress
        //Start all game related logic
    }

    private void HandleWin()
    {
        // Logic for winning the game
    }

    private void HandleLose()
    {
        // Logic for losing the game
    }
    
    private void HandlePause()
    {
        // Logic For Game Pause
    }

    //Permet d'appeler la sc�ne Menu gr�ce au bouton return
    public void ReturnButton()
    {
        SceneManager.LoadScene("Menu");
    }
}

//gamestate permet de savoir l'etat actuel du jeu
public enum GameState
{
    GameStart,
    InGame,
    Win,
    Lose,
    Pause
}