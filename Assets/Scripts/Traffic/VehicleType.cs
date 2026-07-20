using UnityEngine;

public class VehicleType : MonoBehaviour
{
    [SerializeField] private Sprite _carSprite, _truckSprite;
    private void Start()
    {
        SetVehicle();
    }
    public void SetVehicle()
    {
        int randomSprite = Random.Range(0, 4);

        if (randomSprite >= 1)
        {
            GetComponent<SpriteRenderer>().sprite = _carSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = _truckSprite;
        }
    }
}
