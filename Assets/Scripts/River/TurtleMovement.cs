using UnityEngine;

public class TurtleMovement : MonoBehaviour
{
    [SerializeField] public float _moveSpeed;
    [SerializeField] public float _direction;
    [SerializeField] private Vector2 _position;

    private void Update()
    {
        _position = transform.position;

        _position.x += Time.deltaTime * _moveSpeed * _direction;

        transform.position = _position;
    }
}
