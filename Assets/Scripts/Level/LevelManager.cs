using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private SpawnerManager _trafficSpawnerManager;
    [SerializeField] private SpawnerManager _riverSpawnerManager;
    

    public void LevelCompleted()
    {
        StartCoroutine(LevelCompletedUpdate());
    }

    private IEnumerator LevelCompletedUpdate()
    {
        yield return new WaitForSeconds(1f);
        
        _scoreManager.UpdateScore();
        yield return null;

        _uiManager.TurnOnTransition();
        ResetLevel();

        _trafficSpawnerManager.IncreaseSpeed();
        _riverSpawnerManager.IncreaseSpeed();
        

        yield return new WaitForSeconds(1f);

        yield return null;
    }
    public void ResetLevel()
    {
        _playerController.ResetPlayer();
    }
}
