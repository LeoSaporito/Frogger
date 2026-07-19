using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    [SerializeField] private bool _isOnRiver;
    [SerializeField] private float _riverMoveSpeed;
    [SerializeField] private float _riverDirection;

    private void Start()
    {
        GetScripts();
    }
    private void GetScripts()
    {
        _playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
        MoveWithRiver();
    }
    public void MoveLeft()
    {
        transform.position = new Vector3(transform.position.x - 2, transform.position.y, 0);
        transform.eulerAngles = new Vector3(0, 0, 90);
    }
    public void MoveRight()
    {
        transform.position = new Vector3(transform.position.x + 2, transform.position.y, 0);
        transform.eulerAngles = new Vector3(0, 0, -90);
    }
    public void MoveUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2, 0);
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void MoveDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 2, 0);
        transform.eulerAngles = new Vector3(0, 0, 180);
    }    
    public void MoveWithRiver()
    {
        if (_isOnRiver)
        {
            Vector2 _position = transform.position;

            _position.x += Time.deltaTime * _riverMoveSpeed * _riverDirection;
        
            transform.position = _position;
        }
    }
    public void StartMoveOnRiver(float direction, float moveSpeed)
    {
        _isOnRiver = true;

        _riverMoveSpeed = moveSpeed;
        _riverDirection = direction;
    }
    public void StopMoveOnRiver()
    {
        _isOnRiver = false;

        _riverMoveSpeed = 0f;
        _riverDirection = 0f;
    }
}
