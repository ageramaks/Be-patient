using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
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
   
    public void Buy(int id)
    {
        
        if(_products[id].Coast <= PlayerPref.MoneyCard)
        {
            Fridge.Add(_products[id]);
            
            PlayerPref.MoneyCard -= _products[id].Coast;
        }
        else
        {
            Debug.Log("Не хватает денег");
        }


    }


    
}
