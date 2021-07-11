using UnityEngine;

public class ColorHovering : MonoBehaviour
{
    [SerializeField] private Color _enterHoverColor;
    [SerializeField] private Color _clickHoverColor;
    private Color _startColor;
    private Color GetColor(){ return GetComponent<SpriteRenderer>().color; }
    private void SetColor(Color color){ GetComponent<SpriteRenderer>().color = color; }
    
    private void Start()
    {
        _startColor = GetColor();
    }

    private void OnMouseEnter()
    {
        SetColor(_enterHoverColor);
    }

    private void OnMouseExit()
    {
        SetColor(_startColor);
    }
    private void OnMouseDown()
    {
        SetColor(_clickHoverColor);
    }
}
