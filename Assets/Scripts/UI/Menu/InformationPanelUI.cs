using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InformationPanelUI : WindowManager
{ 
   
    [SerializeField] Guide guide;
    [SerializeField] private StartGame _startGame;
    [SerializeField] private Button _informationPanelButton;
    [SerializeField] private GameObject _gameName;
    public override void Init(bool isOpen = false) {
        base.Init(isOpen);
        guide.Init();
        _informationPanelButton.onClick.AddListener(HideOtherElements);
    }
    
    private void HideOtherElements()
    {
        guide.Open();
        _startGame.Close();
        _gameName.SetActive(false);
        _informationPanelButton.gameObject.SetActive(false);
    }
}
