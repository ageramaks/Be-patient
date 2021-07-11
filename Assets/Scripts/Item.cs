using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Image _image;
    private float _ñoast;
    private string _name;
    public float Coast { get { return _ñoast; } }
    public string Name { get { return _name; } }
    public Image Image { get { return _image; } set { _image = value; } }
    public Item(float coast, string name)
    {
        _name = name;
        _ñoast = coast;
        
    }

    
    
}
