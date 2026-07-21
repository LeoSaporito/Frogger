using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SpawnerManager _riverSpawnerManager;
    [SerializeField] private SpawnerManager _trafficSpawnerManager;

    [SerializeField] private LevelManager _levelManager;

    [SerializeField] private PlayerController _playerController;

    [SerializeField] private bool _isPaused;
    private void Update()
    {
        Pause();
    }
    public void GoalReached()
    {
        _isPaused = true;
        _playerController._isGoalReached = true;
        _levelManager.LevelCompleted();
    }
    public void StartNextLevel()
    {
        _riverSpawnerManager.IncreaseSpeed();
        _trafficSpawnerManager.IncreaseSpeed();
    }
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = !_isPaused;
        }

        if (_isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }
    public void PauseGame()
    {
        _riverSpawnerManager.PauseSpawners();
        _trafficSpawnerManager.PauseSpawners();
    }
    public void ResumeGame()
    {
        _riverSpawnerManager.ResumeSpawners();
        _trafficSpawnerManager.ResumeSpawners();
    }
}
