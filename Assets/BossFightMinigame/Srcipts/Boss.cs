using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private static int _hp = 100;

    public static void ReduceHp(int value)
    {
        _hp -= value;
    }
}
