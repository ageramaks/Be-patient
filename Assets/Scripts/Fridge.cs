using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    [SerializeField] private Menu _menu;
    [SerializeField] private Canvas _canvas;

    private static FridgeCells[] _FridgeInventoryCells;
    private static List<Item> products = new List<Item>();
    private static int _cell;
    private void OnMouseDown()
    {
        if (Menu.ClickAble)
        {
            _canvas.gameObject.SetActive(!_canvas.gameObject.activeSelf);
            _menu.gameObject.SetActive(!_menu.gameObject.activeSelf);

        }

    }
    private void Start()
    {
        _FridgeInventoryCells = GetComponents<FridgeCells>();
    }
    public static void Add(Item item)
    {
        if (_cell < products.Count)
        {
            products.Add(item);
            _FridgeInventoryCells[_cell] = item.Image;
            _cell++;
        }
        else
        {
            Debug.Log("Холодильник переполнен");
        }
        
    }
}
