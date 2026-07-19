using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private CollisionManager _collisionManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            GameObject _vehicleObj = collision.gameObject;
        }
        else if (collision.gameObject.CompareTag("River"))
        {
            _collisionManager.OnRiver();
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            _collisionManager.OnGoal();
        }
    }
}
