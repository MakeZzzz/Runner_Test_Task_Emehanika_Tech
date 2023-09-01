using TMPro;
using UnityEngine;

public class GameOverUI : WindowManager
{
    [SerializeField] PauseMenuUI pauseMenuUI;
    [SerializeField] TMP_Text TotalScore;
    
    public override void Init(bool isOpen = false) 
    {
        base.Init(isOpen);
        pauseMenuUI.Init(true);
    }
    public void SetTotalScore(int value) => TotalScore.text = "Score: " + value;
}
