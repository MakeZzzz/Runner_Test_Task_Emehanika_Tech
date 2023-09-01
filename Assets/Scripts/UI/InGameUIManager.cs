using UnityEngine;

public class InGameUIManager : MonoBehaviour
{ 
    public InGameManager inGameManager;
    public InGameUI inGameUI;
    
    [SerializeField] private MainMenuUI _mainMenuUI;
    
    public void Init(InGameManager value)
    {
        inGameManager = value;
        _mainMenuUI.Init(true);
        inGameUI.Init();
    }
    public void OpenGame() 
    {
        inGameUI.Open();
        _mainMenuUI.Close();
    }
    public void CloseGame() 
    {
        _mainMenuUI.Open();
        inGameUI.Close();
    }
    
    public void RestartGame() 
    {
        inGameUI.CloseGameOver();
        inGameUI.RestartScore();
        inGameUI.ClosePauseMenu();
        UnfreezeGame();
    }
    public void FreezeGame() => inGameManager.FreezeGame();
    public void UnfreezeGame() => inGameManager.UnfreezeGame();
}
