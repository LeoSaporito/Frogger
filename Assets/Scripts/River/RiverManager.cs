using UnityEngine;

public class RiverManager : MonoBehaviour
{
    [SerializeField] private RiverSpawner[] _riverSpawners;
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
}