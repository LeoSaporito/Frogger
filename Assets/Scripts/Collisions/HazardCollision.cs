using UnityEngine;

public class HazardCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject _player = collision.gameObject;

            PlayerDeath _playerDeath = _player.GetComponent<PlayerDeath>();

            _playerDeath.Die();
        }
    }
}
