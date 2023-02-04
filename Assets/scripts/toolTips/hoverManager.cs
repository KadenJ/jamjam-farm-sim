using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hoverManager : MonoBehaviour
{
    public TextMeshProUGUI tipText;
    public RectTransform tipWindow;

    public static Action<string, Vector2> OnMouseHover;
    public static Action OnMouseloseFocus;

    private void OnEnable()
    {
        OnMouseHover += showTip;
        OnMouseloseFocus += hideTip;

    }

    private void OnDisable()
    {
        OnMouseHover -= showTip;
        OnMouseloseFocus -= hideTip;
    }

    // Start is called before the first frame update
    void Start()
    {
        hideTip();
    }

    private void showTip(string tip, Vector2 mousePos)
    {
        tipText.text = tip;
        tipWindow.sizeDelta = new Vector2(tipText.preferredWidth > 200 ? 200:tipText.preferredWidth, tipText.preferredHeight);

        tipWindow.gameObject.SetActive(true);
        tipWindow.transform.position = new Vector2(mousePos.x + tipWindow.sizeDelta.x+25, mousePos.y);
    }

    private void hideTip()
    {
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }

}
