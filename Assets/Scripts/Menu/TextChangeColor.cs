using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TextChangeColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Color _downColor, _upColor;

    [SerializeField]
    private TMP_Text text;

    private void Start()
    {
        _downColor = Color.black;
        _upColor = Color.white;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = _downColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = _upColor;
    }
}
