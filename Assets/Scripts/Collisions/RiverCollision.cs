using UnityEngine;

public class RiverCollision : MonoBehaviour
{
    [SerializeField] public float _moveSpeed;
    [SerializeField] public float _direction;
    private void GetObjectData()
    {
        Movements _riverMovement = GetComponent<Movements>();

        _moveSpeed = _riverMovement._moveSpeed;
        _direction = _riverMovement._direction;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetObjectData();

            GameObject _player = collision.gameObject;

            PlayerMovement _playerMovement = _player.GetComponent<PlayerMovement>();

            _playerMovement.StartMoveOnRiver(_direction, _moveSpeed);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetObjectData();

            GameObject _player = collision.gameObject;

            PlayerMovement _playerMovement = _player.GetComponent<PlayerMovement>();

            _playerMovement.StopMoveOnRiver();
        }
    }
}
