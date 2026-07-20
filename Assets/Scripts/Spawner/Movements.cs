using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField] public float _moveSpeed;
    [SerializeField] public float _direction;
    [SerializeField] private Vector2 _position;

    [SerializeField] public bool _isPaused;
    private void Start()
    {
        _isPaused = false;
    }
    private void Update()
    {
        if (_isPaused) { return; }
        else
        {
            _position = transform.position;

            _position.x += Time.deltaTime * _moveSpeed * _direction;

            transform.position = _position;
        }
    }
}
