using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Menu : MonoBehaviour
{
    private static bool _clickAble = false;

    public static bool ClickAble
    {
        get { return _clickAble; }
        set { _clickAble = value; }
    }
}
