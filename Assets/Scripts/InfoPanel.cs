
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel: MonoBehaviour
{
    [SerializeField]private Sprite _picture;

    private static Text _panelText;
    public static Text AddText{ set { _panelText = value; }}
 
}
