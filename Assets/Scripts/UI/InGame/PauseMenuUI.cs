using UnityEngine;
using UnityEngine.UI;

public class PauseMenuUI : WindowManager
{ 
    [SerializeField] private InGameUI _inGameUI;
    [SerializeField] private Button _continueGameButton;
    [SerializeField] private Button _menuButton; 
    [SerializeField] private Button _restartGameButton;

    public override void Init(bool isOpen = false)
    {
        base.Init(isOpen);
        _continueGameButton.onClick.AddListener(ContinueGame);
        _menuButton.onClick.AddListener(CloseGame);
        _restartGameButton.onClick.AddListener(RestartGame);
    }
    private void ContinueGame() 
    {
        _inGameUI.ClosePauseMenu();
        _inGameUI.UnfreezeScore();
        _inGameUI.inGameUIManager.UnfreezeGame();
    }
    private void RestartGame() 
    {
        _inGameUI.inGameUIManager.inGameManager.RestartGame();
    }
    private void CloseGame() 
    {
        RestartGame();
        _inGameUI.CloseGame();
    }
}
