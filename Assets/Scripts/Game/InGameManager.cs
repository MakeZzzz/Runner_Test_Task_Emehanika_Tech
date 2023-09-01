using UnityEngine;

public class InGameManager : MonoBehaviour
{
    [SerializeField] private InGameUIManager _inGameUIManager;
    [SerializeField] private LevelController _levelController;
    
    void Awake() 
    { 
        Init();
    }
    private void Init() 
    { 
        _inGameUIManager.Init(this); 
        FreezeGame(); 
    }
    public void FreezeGame()
    {
        Time.timeScale = 0;
    } 
    public void UnfreezeGame() 
    { 
        Time.timeScale = 1;
    }
    public void RestartGame() 
    { 
        _inGameUIManager.RestartGame();
        _levelController.SetStartPosition();
    }
        
    public void DecreaseFire() => _inGameUIManager.inGameUI.DecreaseFire(); 
    public void IncreaseFire() => _inGameUIManager.inGameUI.IncreaseFire();
}
