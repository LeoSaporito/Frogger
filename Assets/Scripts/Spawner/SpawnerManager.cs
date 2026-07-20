using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _increaseMoveSpeed;
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
    public void PauseRiver()
    {
        for (int i = 0; i < _spawners.Length; i++)
        {
            _spawners[i].PauseSpawner();
        }
    }
}
