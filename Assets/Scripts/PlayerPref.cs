using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPref 
{
    private static float _money;
    
    public static float Money { get { return _money; } set { _money = value; } }

    public static List<Item> products = new List<Item>();
}
