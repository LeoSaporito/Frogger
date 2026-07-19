using UnityEngine;

public class GoalCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject _player = collision.gameObject;

            _player.GetComponent<PlayerController>().GoalReached();
        }
    }
}
