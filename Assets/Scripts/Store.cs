using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Store : MonoBehaviour
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set 
        { 
          if(value <= _products.Length)
            {
                _id = value;
            }

        }
    }

    private static Item[] _products =
        {
        new  Item (200f,"pizza"),
        new Item(100f,"milk"),
        new Item(70f,"doshik"),
        };
    private void Start()
    {
        
    }
    public void Buy(int id)
    {
        PlayerPref.products.Add(_products[id]);
        Debug.Log("добавлен предмет " + _products[id].Name);
    }


    private void CheckCoast()
    {
        
    }
}
