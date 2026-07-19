using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    [SerializeField] private VehicleSpawner[] _vehicleSpawners;
    [SerializeField] private float _increaseMoveSpeed;

    private void IncreaseVehicleSpeed()
    {
        for (int i = 0; i<_vehicleSpawners.Length; i++)
        {
            _vehicleSpawners[i]._moveSpeed += _increaseMoveSpeed;
        }
    }
    private void StopTraffic()
    {
        for (int i = 0; i < _vehicleSpawners.Length; i++)
        {
            _vehicleSpawners[i]._isSpawning = false;
        }
    }
    private void StartTraffic()
    {
        for (int i = 0; i < _vehicleSpawners.Length; i++)
        {
            _vehicleSpawners[i]._isSpawning = true;
        }
    }
}
