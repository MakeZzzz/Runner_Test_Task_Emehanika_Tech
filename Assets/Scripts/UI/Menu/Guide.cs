using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Guide : WindowManager
{
    [SerializeField]  Button CloseInformationPanelButton;
    [SerializeField] private StartGame _startGame;
    [SerializeField] private Button _informationPannelButton;
    [SerializeField] private GameObject _gameName;
    public override void Init(bool isOpen = false) {
        base.Init(isOpen);
        CloseInformationPanelButton.onClick.AddListener(Close);
        CloseInformationPanelButton.onClick.AddListener(DisplayOtherElements);
    }
    private void DisplayOtherElements(){
        _startGame.Open(); 
        _informationPannelButton.gameObject.SetActive(true); 
        _gameName.SetActive(true);
    }
}
