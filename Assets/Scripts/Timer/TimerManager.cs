using System;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] public float timer;
    [SerializeField] public int _timerProgress;
    [SerializeField] private int _timerMin;
    [SerializeField] public int _timerMax;

    [SerializeField] private bool _stopTimer;
    private void Start()
    {
        ResetTimer();
    }
    private void Update()
    {
        StartTimer();
    }
    private void StartTimer()
    {
        if (_stopTimer) { return; }
        else
        {
             timer += Time.deltaTime;

            _timerProgress = _timerMax - (int)timer;
        }
    }
    public void LevelCompleted()
    {
        _stopTimer = true;
    }
    public void ResetTimer()
    {
        _stopTimer = false;
        _timerProgress = _timerMax;
    }
}
