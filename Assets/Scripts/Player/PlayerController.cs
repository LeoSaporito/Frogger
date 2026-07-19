using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector2 directionalInput;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerDeath _playerDeath;
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
        if (!_playerDeath._isAlive) { return; }
        else
        {
            Movement();
        }
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
}
