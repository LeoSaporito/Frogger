using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _speedIncreaseValue;

    private void StopTraffic()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i]._isSpawning = false;
        }
    }
    private void StartTraffic()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i]._isSpawning = true;
        }
    }
    public void IncreaseSpeed()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i]._moveSpeed += _speedIncreaseValue;
        }
    }
    public void PauseSpawners()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i].PauseObjects();
        }
    }
    public void ResumeSpawners()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i].ResumeObjects();
        }
    }
}
