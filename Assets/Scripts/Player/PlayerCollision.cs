using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            GameObject _goal = collision.gameObject;

            _goal.GetComponent<GoalManager>().GoalReached();
        }
    }
}
