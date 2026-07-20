using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    [SerializeField] private Spawner[] _Spawners;
    [SerializeField] private float _increaseMoveSpeed;
    [SerializeField] private float _speedIncreaseValue;

    private void StopTraffic()
    {
        for (int i = 0; i < _Spawners.Length; i++)
        {
            _Spawners[i]._isSpawning = false;
        }
    }
    private void StartTraffic()
    {
        for (int i = 0; i < _Spawners.Length; i++)
        {
            _Spawners[i]._isSpawning = true;
        }
    }
    public void IncreaseSpeed()
    {
        for (int i = 0; i < _Spawners.Length; i++)
        {
            _Spawners[i]._moveSpeed += _speedIncreaseValue;
        }
    }
}
