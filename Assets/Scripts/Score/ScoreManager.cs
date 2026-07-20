using System.Collections;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TimerManager _timerManager;
    [SerializeField] private int _score;
    [SerializeField] private int _addToScore;
    [SerializeField] private float _timer;
    [SerializeField] private float _scoreSpeed;
    public void UpdateScore()
    {
        StartCoroutine(ScoreUpdate());
    }
    private IEnumerator ScoreUpdate()
    {
        _timerManager.LevelCompleted();

        _addToScore = _timerManager._timerProgress;

        int _totalScore = _score + _addToScore;

        while (_score < _totalScore)
        {
            _timer += Time.deltaTime * _scoreSpeed;

            _score = (int)_timer;
        
            yield return null;
        }
        _addToScore = 0;
        _timer = 0f;
        
        yield return null;
    }
}
