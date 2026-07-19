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
            CreateLog();
            CreateTurtle();

            _duration = ChangeSpawnRate();
            _progress = 0f;
        }
        else
        {
            _progress += Time.deltaTime;
        }
    }
    private void CreateLog()
    {
        if (_isLogSpawner)
        {
            GameObject _logObj = Instantiate(_logPrefab, transform.position, Quaternion.identity, transform);
            LogMovement _logMovement = _logObj.GetComponent<LogMovement>();

            _logMovement._moveSpeed = _moveSpeed;
            _logMovement._direction = _direction;
        }
    }
    private void CreateTurtle()
    {
        if (!_isLogSpawner)
        {
            GameObject _turtleObj = Instantiate(_turtlePrefab, transform.position, Quaternion.identity, transform);
            TurtleMovement _turtleMovement = _turtleObj.GetComponent<TurtleMovement>();

            _turtleMovement._moveSpeed = _moveSpeed;
            _turtleMovement._direction = _direction;
        }
    }
    private float ChangeSpawnRate()
    {
        float newDuration = Random.Range(_minSpawnTime, _maxSpawnTime);

        return newDuration;
    }
}
