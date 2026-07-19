using System;
using UnityEngine;
using UnityEngine.UIElements;

public class VehicleMovement : MonoBehaviour
{
    [SerializeField] public float _direction;
    [SerializeField] public float _moveSpeed;
    [SerializeField] public Vector2 _position;
    private void Update()
    {
        _position = transform.position;

        _position.x += Time.deltaTime * _moveSpeed * _direction;
        
        transform.position = _position;
    }
}
