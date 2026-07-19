using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    private void Start()
    {
        GetScripts();
    }
    private void GetScripts()
    {
        _playerController = GetComponent<PlayerController>();
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
}
