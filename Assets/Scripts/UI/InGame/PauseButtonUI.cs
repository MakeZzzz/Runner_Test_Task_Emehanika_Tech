using UnityEngine;
using UnityEngine.UI;

public class PauseButtonUI : WindowManager
{
    public InGameUI InGameUI;
    
    [SerializeField] private Button openPauseMenuButton;
    public override void Init(bool isOpen = false) 
    {
        base.Init(isOpen);
        openPauseMenuButton.onClick.AddListener(InGameUI.OpenPauseMenu);
    }
}
