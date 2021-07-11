using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    [SerializeField] private Sprite[] _sprites;
    [SerializeField] private Menu _menu;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Image[] _FridgeInventoryCells;
    private static int _maximumCell = 6;
  
    private static List<Item> _products = new List<Item>();
    private static int _cell = 0;

    private static bool _checkSell = false;
    
    private void OnMouseDown()
    {
        if (Menu.ClickAble)
        {
            _canvas.gameObject.SetActive(!_canvas.gameObject.activeSelf);
            _menu.gameObject.SetActive(!_menu.gameObject.activeSelf);

            
           



        }

    }

    private void Update()
    {
        if (_checkSell)
            CheckSells();
    }


    public static void Add(Item item)
    {
        
       
        if (_cell < _maximumCell)
        {
            _products.Add(item);
            Debug.Log("добавлен предмет " + _products[_cell].Name);
            _cell++;
            _checkSell = true;

        }
        else
        {
            Debug.Log("Холодильник переполнен");
            
        }
        
    }

    public void CheckSells()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            if (_products[i].Name == "pizza")
                _FridgeInventoryCells[i].sprite = _sprites[0];
            else if (_products[i].Name == "milk")
                _FridgeInventoryCells[i].sprite = _sprites[1];
            else if (_products[i].Name == "doshik")
                _FridgeInventoryCells[i].sprite = _sprites[2];
        }
        _checkSell = false;
    }
}
