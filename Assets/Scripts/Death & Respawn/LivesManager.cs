using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] public int _numberOfLives;
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector2 _spawnPoint;

    public void LoseLife()
    {
        if (_numberOfLives == 0)
        {
            _player.GetComponent<PlayerController>()._isGameOver = true;
        }
        else
        {
            _numberOfLives--;
            Respawn();
        }
    }
    private void Respawn()
    {
        _player.transform.position = _spawnPoint;
        _player.transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
