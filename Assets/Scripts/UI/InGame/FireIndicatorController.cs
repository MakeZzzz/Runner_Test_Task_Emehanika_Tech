using System.Collections.Generic;
using UnityEngine;
public class FireIndicatorController : WindowManager 
{ 
    [SerializeField] private InGameUI inGameUI; 
    [SerializeField] private List<GameObject> _fireIcons = new List<GameObject>(); 
    [SerializeField] private int _baseFireIconsCount = 3; 
    
    private int _maxFireIconsCount = 7; 
    private int _currentFireIconsCount; 
    public override void Init(bool isOpen = false) 
    { 
        base.Init(isOpen); 
        StartingAmountFire();
    } 
    public void StartingAmountFire() 
    { 
        _currentFireIconsCount = _baseFireIconsCount; 
        for(var i = 0; i < _currentFireIconsCount; i++) 
        { 
            _fireIcons[i].SetActive(true); 
        }
    } 
    public void IncreaseFire()
    {
        if (_currentFireIconsCount >= _maxFireIconsCount) return;
        _currentFireIconsCount++; 
        _fireIcons[_currentFireIconsCount-1].SetActive(true);
    } 
    public void DecreaseFire() 
    { 
        _currentFireIconsCount--; 
        if(_currentFireIconsCount > 0)
        { 
            _fireIcons[_currentFireIconsCount].SetActive(false);
        }
        else 
        { 
            inGameUI.GameOver();
        }
    } 
}
