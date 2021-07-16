using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public void ChangeOfState(GameObject _gameObject)
    {
        _gameObject.gameObject.SetActive(!_gameObject.gameObject.activeSelf);
    }

}
