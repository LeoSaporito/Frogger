using UnityEngine;

public class RiverSpawner : MonoBehaviour
{
    [SerializeField] private bool _isLogSpawner;

    [SerializeField] private GameObject _logPrefab;
    [SerializeField] private GameObject _turtlePrefab;
    
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _direction;

    [SerializeField] private float _progress;
    [SerializeField] private float _duration;

    [SerializeField] public float _minSpawnTime;
    [SerializeField] public float _maxSpawnTime;

    [SerializeField] public bool _isSpawning;
    private void Start()
    {
        _duration = ChangeSpawnRate();
    }
    private void Update()
    {
        if(!_isSpawning) { return; }
        else
        {
            Spawner();
        }
    }
    private void Spawner()
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
        else
        {
            Create(_turtlePrefab);
        }
    }
    private void Create(GameObject _prefab)
    {
        GameObject _Obj = Instantiate(_prefab, transform.position, Quaternion.identity, transform);
        RiverMovement _riverMovement = _Obj.GetComponent<RiverMovement>();

        _riverMovement._moveSpeed = _moveSpeed;
        _riverMovement._direction = _direction;
    }
    private float ChangeSpawnRate()
    {
        float newDuration = Random.Range(_minSpawnTime, _maxSpawnTime);

        return newDuration;
    }
}
