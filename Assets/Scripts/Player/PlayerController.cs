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
    
    [SerializeField] public bool _isPaused;
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
        if (_isGameOver || _isGoalReached || _isPaused) { return; }
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
    }
    public void GoalReached()
    {
        _isGoalReached = true;
    }
    public void PausePlayer()
    {
        _isPaused = true;
    }
    public void ResumePlayer()
    {
        _isPaused = false;
    }
    public void ResetPlayer()
    {
        transform.position = new Vector3(0, -8, 0);
        transform.position = new Vector3(0, -8, 0);
    }
}
