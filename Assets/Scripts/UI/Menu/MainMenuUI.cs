using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MainMenuUI : WindowManager
{
    [SerializeField] StartGame startGame; 
    [SerializeField] InformationPanelUI informationPanelUI;
    [HideInInspector] public InGameUIManager inGameUIManager;
    public override void Init(bool isOpen = false) {
        base.Init(isOpen);
        inGameUIManager = GetComponentInParent<InGameUIManager>();
        startGame.Init(true);
        informationPanelUI.Init(true);
    }
}
