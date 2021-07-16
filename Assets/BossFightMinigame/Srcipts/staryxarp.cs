using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class staryxarp : MonoBehaviour
{
    [SerializeField] private int Hpstar;

    [SerializeField] private Text HPTEXT;

    [SerializeField] private GameObject AttackButton;
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject win;
    
    private void Start() 
    {
        Hpstar = 10;
        AttackButton.SetActive(false);
        StartCoroutine(ButtonActive());
    }

    IEnumerator ButtonActive()
    {
        yield return new WaitForSeconds(6);
        {
            AttackButton.SetActive(true);
        }
    }

    public void OnClickButton()
    {
        Hpstar--;
        AttackButton.SetActive(false);
    }

    private void Update() 
    {
        if (Hpstar <= 0)
        {
            game.SetActive(false);
            win.SetActive(true);
        }
        HPTEXT.text = Hpstar.ToString();
    }
}
