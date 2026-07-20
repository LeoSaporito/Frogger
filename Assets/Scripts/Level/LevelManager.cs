using System;
using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ScoreManager _scoreManager;

    public void LevelCompleted()
    {
        StartCoroutine(LevelCompletedUpdate());
    }

    private IEnumerator LevelCompletedUpdate()
    {
        yield return new WaitForSeconds(1f);
        _scoreManager.UpdateScore();
        yield return null;
    }
}
