using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Item : MonoBehaviour
{
    
    private Sprite _sprite;
    private float _�oast;
    private string _name;
    public float Coast { get { return _�oast; } }
    public string Name { get { return _name; } }
    public Sprite sprite { get { return _sprite; } set { _sprite = value; } }
    public Item(float coast, string name)
    {
        _name = name;
        _�oast = coast;
        
    }

    
    
}
