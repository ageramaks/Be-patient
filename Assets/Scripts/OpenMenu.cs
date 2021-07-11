using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    [SerializeField] private Menu _menu;

    private void OnMouseDown()
    {
        if (PC.ClickAble)
        {
            _menu.gameObject.SetActive(!_menu.gameObject.activeSelf);
        }
    }
}
