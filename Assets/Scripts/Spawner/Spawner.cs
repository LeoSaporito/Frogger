using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private bool _isLogSpawner;
    [SerializeField] private bool _isTurtleSpawner;
    [SerializeField] private bool _isVehicleSpawner;

    [SerializeField] private GameObject _logPrefab;
    [SerializeField] private GameObject _turtlePrefab;
    [SerializeField] private GameObject _vehiclePrefab;

    [SerializeField] public float _moveSpeed;
    [SerializeField] private float _direction;

    [SerializeField] private float _progress;
    [SerializeField] private float _duration;

    [SerializeField] public float _minSpawnTime;
    [SerializeField] public float _maxSpawnTime;

    [SerializeField] public bool _isSpawning;
    [SerializeField] public bool _isPaused;

    [SerializeField] private List<GameObject> _spawnedObjList = new List<GameObject>();

    private void Start()
    {
        _duration = ChangeSpawnRate();
    }
    private void Update()
    {
        if (!_isSpawning) { return; }
        else
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        if (_progress > _duration)
        {
            ObjectToSpawn();

            _duration = ChangeSpawnRate();
            _progress = 0f;
        }
        else
        {
            _progress += Time.deltaTime;
        }
    }
    private void ObjectToSpawn()
    {
        if (_isLogSpawner)
        {
            Create(_logPrefab);
        }
        else if (_isTurtleSpawner)
        {
            Create(_turtlePrefab);            
        }
        else if(_isVehicleSpawner)
        {
            Create(_vehiclePrefab);
        }
    }
    private void Create(GameObject _prefab)
    {
        GameObject _obj = Instantiate(_prefab, transform.position, Quaternion.identity, transform);
        Movements _movement = _obj.GetComponent<Movements>();
        Despawn _despawn = _obj.GetComponent<Despawn>();

        _movement._moveSpeed = _moveSpeed;
        _movement._direction = _direction;
        _movement.transform.localScale = new Vector3(_direction, 1, 1);

        _despawn.InitializeScript(this);

        _spawnedObjList.Add(_obj);
    }
    private float ChangeSpawnRate()
    {
        float newDuration = Random.Range(_minSpawnTime, _maxSpawnTime);

        return newDuration;
    }
    public void DespawnObj(GameObject _spawnedObj)
    {
        _spawnedObjList.Remove(_spawnedObj);
        Destroy(_spawnedObj);
    }
    public void PauseSpawner()
    {
        _isSpawning = false;
        for (int i = 0; i < _spawnedObjList.Count; i++)
        {
            _spawnedObjList[i].GetComponent<Movements>()._isPaused = true;
        }
    }
    public void ResumeSpawner()
    {
        _isSpawning = true;
        for (int i = 0; i < _spawnedObjList.Count; i++)
        {
            _spawnedObjList[i].GetComponent<Movements>()._isPaused = false;
        }
    }
}
