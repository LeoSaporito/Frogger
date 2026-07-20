using UnityEngine;

public class RiverManager : MonoBehaviour
{
    [SerializeField] private RiverSpawner[] _riverSpawners;
    [SerializeField] private float _speedIncreaseValue;
    private void StartSpawning()
    {
        for (int i = 0; i < _riverSpawners.Length; i++)
        {
            _riverSpawners[i]._isSpawning = true;
        }
    }
    private void StopSpawning()
    {
        for (int i = 0; i < _riverSpawners.Length; i++)
        {
            _riverSpawners[i]._isSpawning = false;
        }
    }
    public void IncreaseSpeed()
    {
        for (int i = 0; i < _riverSpawners.Length; i++)
        {
            _riverSpawners[i]._moveSpeed += _speedIncreaseValue;
        }
    }
    public void PauseRiver()
    {
        for (int i = 0; i < _riverSpawners.Length; i++)
        {
            _riverSpawners[i].PauseSpawner();
        }
    }
}