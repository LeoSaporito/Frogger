using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] public LivesManager _livesManager;

    [SerializeField] public GameObject _gravePrefab;

    [SerializeField] private Vector2 _spawnPoint;

    public void Die()
    {
        Instantiate(_gravePrefab, transform.position, Quaternion.identity);

        _livesManager.LoseLife();
        
        if (_livesManager._numberOfLives > 0)
        {
            Respawn();
        }
    }
    private void Respawn()
    {
        transform.position = _spawnPoint;
        transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
