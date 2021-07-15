using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public  class PlayerPref : MonoBehaviour
{
    [SerializeField] private Text _dayInfo;
    [SerializeField] private Text _moneyInfo;
    [SerializeField] private Text _stateInfo;
    private static float _moneyCash = 200;
    private static float _moneyCard = 200;
    private static int _day;
    private  string _state;
    
    public static int Day { get { return _day; } set { _day = value; } }
    public static float MoneyCard { get { return _moneyCard; } set { _moneyCard = value; } }
    public static float MoneyCash{ get { return _moneyCash; } set { _moneyCash = value; } }
    private void Update()
    {
        _moneyInfo.text = $"Кошелек: {_moneyCash}Р | Карта: {_moneyCard}Р";
        _dayInfo.text = $"День {_day}";
        _stateInfo.text = _state;
    }

}
