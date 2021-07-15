using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class SkipDay : MonoBehaviour
{
    [SerializeField] GameObject _backGroundAnim;
    [SerializeField] private Text _dayCanvas;

    public delegate void Skip(int dayCount);
    private void OnMouseDown()
    {
        if (Menu.ClickAble)
        {
            Skip1();
            
        }
    }
    private void Skip1()
    {
        PlayerPref.Day++;
        _dayCanvas.text = $"демэ {PlayerPref.Day}";
        Animator anim = _backGroundAnim.GetComponent<Animator>();
        anim.SetTrigger("DayCounter"); 
    }
   
    


    

}
