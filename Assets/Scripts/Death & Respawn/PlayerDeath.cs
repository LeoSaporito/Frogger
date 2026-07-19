using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] public bool _isAlive;
    private void Start()
    {
        _isAlive = true;
    }
    public void Die()
    {
        _isAlive = false;
    }
}
