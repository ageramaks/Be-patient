using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    
    [SerializeField] private GameObject[] _gameObjects;
    [SerializeField] private GameObject _notif;
    private void Start()
    {
        
        _gameObjects[0].SetActive(true);
    }
    private int count;
    public void NextInfo()
    {
        if (count == _gameObjects.Length)
        {
            Menu.ClickAble = true;
            gameObject.SetActive(false);
            _notif.SetActive(true);

        }
        _gameObjects[count].SetActive(false);
        count++;
         _gameObjects[count].SetActive(true);
        
    }
}
