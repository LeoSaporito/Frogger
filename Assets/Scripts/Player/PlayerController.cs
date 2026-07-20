using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 directionalInput;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerDeath _playerDeath;

    [SerializeField] public bool _isGameOver;
    [SerializeField] public bool _isGoalReached;

    [SerializeField] private GameManager _gameManager;
    private void Start()
    {
        GetScripts();
    }

    private void GetScripts()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerDeath = GetComponent<PlayerDeath>();
    }
    private void Update()
    {
        if (_isGameOver || _isGoalReached) { return; }
        Movement();
    }
    public void Movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _playerMovement.MoveUp();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _playerMovement.MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _playerMovement.MoveDown();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _playerMovement.MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _gameManager.PauseGame();
        }
    }
    public void GoalReached()
    {
        _isGoalReached = true;
    }
}
