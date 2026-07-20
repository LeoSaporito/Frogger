using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    public void GoalReached()
    {
        _gameManager.GoalReached();
    }
}
