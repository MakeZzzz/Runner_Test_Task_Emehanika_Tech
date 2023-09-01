using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class StartGame : WindowManager
{
    [SerializeField] private Button _startGameButton; 
    [SerializeField] private MainMenuUI _mainMenuUI;
    public override void Init(bool isOpen = false) 
    {
        base.Init(isOpen);
        _mainMenuUI = GetComponentInParent<MainMenuUI>();
        _startGameButton.onClick.AddListener(StartGameComponents);
    }
    private void StartGameComponents() 
    {
        _mainMenuUI.inGameUIManager.OpenGame();
        _mainMenuUI.inGameUIManager.UnfreezeGame();
    }
}
