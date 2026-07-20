using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SpawnerManager _riverSpawnerManager;
    [SerializeField] private SpawnerManager _trafficSpawnerManager;

    [SerializeField] private LevelManager _levelManager;

    [SerializeField] private PlayerController _playerController;
    public void GoalReached()
    {
        _levelManager.LevelCompleted();
    }
    public void StartNextLevel()
    {
        _riverSpawnerManager.IncreaseSpeed();
        _trafficSpawnerManager.IncreaseSpeed();
    }

    public void PauseGame()
    {
        _riverSpawnerManager.PauseRiver();
        _trafficSpawnerManager.PauseRiver();
    }
}
