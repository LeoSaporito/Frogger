using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] public LivesManager _livesManager;

    [SerializeField] public GameObject _gravePrefab;

    public void Die()
    {
        Instantiate(_gravePrefab, transform.position, Quaternion.identity);
        _livesManager.LoseLife();
    }
}
