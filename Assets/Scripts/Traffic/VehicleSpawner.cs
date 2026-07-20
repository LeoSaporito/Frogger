using UnityEngine;
using UnityEngine.UIElements;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _vehiclePrefab;    
    [SerializeField] private Sprite _carSprite, _truckSprite;

    [SerializeField] public float _moveSpeed;
    [SerializeField] public int _direction;

    [SerializeField] public float _progress;
    [SerializeField] public float _duration;

    [SerializeField] public float _minSpawnTime;
    [SerializeField] public float _maxSpawnTime;

    [SerializeField] public float _slowLaneOne;
    [SerializeField] public float _slowLaneTwo;

    [SerializeField] public bool _isSpawning;
    private void Start()
    {
        _duration = ChangeSpawnRate();
    }
    private void Update()
    {
        if (!_isSpawning) 
        { 
            return; 
        }
        else
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        if (_progress > _duration)
        {
            CreateVehicle();

            _duration = ChangeSpawnRate();
            _progress = 0f;
        }
        else if (_progress < _duration)
        {
            _progress += Time.deltaTime;
        }
    }
    public void CreateVehicle()
    {
        GameObject _vehicle = Instantiate(_vehiclePrefab, transform.position, Quaternion.identity, transform.parent);
        SetVehicle(_vehicle);

        VehicleMovement _vehicleMovement = _vehicle.GetComponent<VehicleMovement>();
        
        _vehicleMovement._direction = _direction;
        _vehicleMovement._moveSpeed = _moveSpeed;
        _vehicleMovement.transform.localScale = new Vector3(_direction, 1, 1);
    }
    public void SetVehicle(GameObject vehicleObj)
    {
        int randomSprite = Random.Range(0, 4);

        if (randomSprite >= 1)
        {
            vehicleObj.GetComponent<SpriteRenderer>().sprite = _carSprite;
        }
        else
        {
            vehicleObj.GetComponent<SpriteRenderer>().sprite = _truckSprite;
        }
    }
    private float ChangeSpawnRate()
    {
        float newDuration = Random.Range(_minSpawnTime, _maxSpawnTime);

        return newDuration;
    }    
}
