using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] public int _numberOfLives;
    [SerializeField] private GameObject _player;

    public void LoseLife()
    {
        _numberOfLives--;

        print("Lives: " + _numberOfLives);
        
        if (_numberOfLives == 0)
        {
            print("Game Over");
        }
    }
}
