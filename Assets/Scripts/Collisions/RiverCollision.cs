using UnityEngine;

public class RiverCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject _player = collision.gameObject;

            PlayerController _playerController = _player.GetComponent<PlayerController>();
        }
    }
}
