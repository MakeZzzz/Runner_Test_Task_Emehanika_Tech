using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreManager : WindowManager
{
    [SerializeField] private TMP_Text _scoreText; 
    [SerializeField] private InGameUI _inGameUI;
    
    private int _currentScore = 0;
    
    private bool _isChangeScore = true;
    private bool isPaused = false;

    public override void Init(bool isOpen = false) 
    {
        base.Init(isOpen);
        _currentScore = 0;
        _scoreText.text = _currentScore.ToString();
        _isChangeScore = true;
    }
    private void Update()
    {
       if(_isChangeScore) StartCoroutine(IncrementScore());
    }

    private IEnumerator IncrementScore()
    {
        _isChangeScore = false;
        yield return new WaitForSeconds(1f);
        _currentScore++;
        _scoreText.text = _currentScore.ToString();
        _inGameUI.SetScore(_currentScore); 
        _isChangeScore = true;
    }
    public void ChangeScore(bool value) => _isChangeScore = value;
}
