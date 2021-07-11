using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class SkipDay : MonoBehaviour
{
    [SerializeField] GameObject _backGroundAnim;
    [SerializeField] private Text _newsCanvas;
    [SerializeField] private Text _infoCanvas;
    [SerializeField] private Text _dayCanvas;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Text[] _choiceButtonsText;
    [SerializeField] private Button[] _choiceButtons;
    [SerializeField] private Button _nextButton;

    [SerializeField] private GameObject[] _notifications;
    private void Start()
    {


    }
    private void OnMouseDown()
    {
        if (Menu.ClickAble)
        {
            Skip();
            
        }
    }
    private void Skip()
    {
        PlayerPref.Day++;
        _dayCanvas.text = $"ДЕНЬ {PlayerPref.Day}";
        Animator anim = _backGroundAnim.GetComponent<Animator>();
        anim.SetTrigger("DayCounter");
        Event();





    }
    private void Event()
    {
        switch (PlayerPref.Day)
        {
            case 1:
                Menu.ClickAble = false;
                AddNote("Первый день самоизоляции.Ничего необычного не произошло. Вам стало скучно и вы решили посмотреть фильм. Какой фильм это будет?");
                TurnOnOffButtons();
                TurnOnOffNottification(1);
                ReplaceTags("Хорор", "Комедия");
                break;
            case 2:
                AddNote("Посмотрев фильм вы не смогли уснуть. Вы провели ночь вздрагивая от непонятного шороха","Вы очень хорошо провели время за просмотром фильма. Вы чувствуете в себе море энергии. Куда бы ее направить?..",_answer);
                _nextButton.gameObject.SetActive(true);
                TurnOnOffButtons();
                TurnOnOffNottification(2);
                break;

        }
    }
    private void TurnOnOffButtons()
    {
        _choiceButtons[0].gameObject.SetActive(!_choiceButtons[0].gameObject.activeSelf);
        _choiceButtons[1].gameObject.SetActive(!_choiceButtons[1].gameObject.activeSelf);
     
    }
    private void TurnOnOffNottification(int id)
    {
        _notifications[0].gameObject.SetActive(!_notifications[0].gameObject.activeSelf);
        _notifications[id].gameObject.SetActive(!_notifications[id].gameObject.activeSelf);
    }
    private bool _answer;
    private void AddNote(string text)
    {
        _canvas.gameObject.SetActive(true);

        _infoCanvas.text = text;
    }
    private void AddNote(string text1,string text2, bool answer)
    {
        _canvas.gameObject.SetActive(true);

        if (answer)
           _infoCanvas.text = text1;
        else
            _infoCanvas.text = text2;

    }

    private void ReplaceTags(string variant1, string variant2)
    {
        
        _choiceButtonsText[0].text = variant1;
        _choiceButtonsText[1].text = variant2;
    }

    public void Answer (bool answer)
    {
        _answer = answer;
        _canvas.gameObject.SetActive(false);

        Menu.ClickAble = true;
        Skip();
        
    }


    

}
