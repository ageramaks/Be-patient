
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Notebook: MonoBehaviour
{
    [SerializeField] private InfoPanel _infoPanel;
    [SerializeField] private Sprite _picture;

    private static Text _panelText;
    public static Text AddText{ set { _panelText = value; }}
 
    public void OpenNotebookPanel()
    {
        Debug.Log("work");
        _infoPanel.gameObject.SetActive(!_infoPanel.gameObject.activeSelf);
    }

}
