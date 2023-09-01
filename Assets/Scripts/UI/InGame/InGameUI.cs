using UnityEngine;

public class InGameUI : WindowManager
{
    
    [SerializeField] private GameOverUI _gameOverUI;
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private FireIndicatorController _fireIndicatorController;
    [SerializeField] private PauseMenuUI _pauseMenuUI; 
    [SerializeField] private PauseButtonUI _pauseButtonUI;
    
    public InGameUIManager inGameUIManager;
    public override void Init(bool isOpen = false) 
    {
        base.Init();
        SetInGameUI();
        SetInitChild();
    }

    private void SetInitChild() 
    {
        _scoreManager.Init(true);
        _fireIndicatorController.Init(true);
        _pauseButtonUI.Init(true);
        _gameOverUI.Init();
        _pauseMenuUI.Init();
        _pauseMenuUI.Init();
    }
    private void SetInGameUI() 
    {
        _pauseButtonUI.InGameUI = this;
    }
    public void OpenPauseMenu() 
    {
        _pauseMenuUI.Open();
        _pauseButtonUI.Close();
        _scoreManager.Close();
        _fireIndicatorController.Close();
        inGameUIManager.FreezeGame();
    }
    public void ClosePauseMenu()
    {
        _pauseMenuUI.Close();
        _pauseButtonUI.Open();
        _scoreManager.Open();
        _fireIndicatorController.Open();
    }

    public void CloseGame() 
    {
        ClosePauseMenu();
        inGameUIManager.FreezeGame();
        inGameUIManager.CloseGame();
    }
    public void GameOver() 
    {
        _gameOverUI.Open();
        _pauseButtonUI.Close();
        _scoreManager.Close();
        _fireIndicatorController.Close();
        inGameUIManager.FreezeGame();
    }
    public void RestartScore()
    {
        _fireIndicatorController.StartingAmountFire();
        _scoreManager.Init();
    }
    
    public void SetScore(int value) => _gameOverUI.SetTotalScore(value);
    public void IncreaseFire() => _fireIndicatorController.IncreaseFire();
    public void DecreaseFire() => _fireIndicatorController.DecreaseFire();
    public void UnfreezeScore() => _scoreManager.ChangeScore(true);
    public void CloseGameOver() =>  _gameOverUI.Close();
}
