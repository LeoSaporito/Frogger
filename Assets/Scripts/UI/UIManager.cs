using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //[SerializeField]
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private TimerManager _timerManager;
    [SerializeField] private TextMeshProUGUI _livesText;

    [SerializeField] private Slider _slider;


    [SerializeField] private GameObject _transition;
    [SerializeField] private TextMeshProUGUI _scoreTextTransition;
    [SerializeField] private TextMeshProUGUI _livesTextTransition;
    private void Start()
    {
        NextLevelUI();
        TurnOffTransition();
    }
    private void NextLevelUI()
    {
        _slider.maxValue = _timerManager._timerMax;
        _slider.value = _timerManager._timerMax;
    }
    private void Update()
    {
        _scoreText.text = "Score: " + _scoreManager._score;
        _highScoreText.text = "High Score: " + _scoreManager._highScore;
    }
    public void TurnOnTransition()
    {
        _transition.SetActive(true);
    }
    public void TurnOffTransition()
    {
        _transition.SetActive(false);
    }
}
