using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : MonoBehaviour
{
    
    [SerializeField] private Menu _menu;
    [SerializeField] private Canvas _canvas;
    private void OnMouseDown()
    {
        if (Menu.ClickAble)
        {
            _canvas.gameObject.SetActive(!_canvas.gameObject.activeSelf);
            _menu.gameObject.SetActive(!_menu.gameObject.activeSelf);
           
        }
    }
}
