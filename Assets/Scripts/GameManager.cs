using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, SceneLoading, LevelLoading, Play, PauseMenu };
    public GameState gameState;
    public bool debugMode = true;

    public UnityAction<GameState> onGameStateChange;

    private static GameManager m_instance;
    public static GameManager Instance
    {
        get
        {
            if (m_instance == null)
                m_instance = FindObjectOfType<GameManager>();
            return m_instance;
        }
    }

    private void Awake()
    {
        if (Instance != this) Destroy(gameObject);
    }

    public void ChangeState(GameState state)
    {
        gameState = state;
        onGameStateChange.Invoke(state);
    }

}
