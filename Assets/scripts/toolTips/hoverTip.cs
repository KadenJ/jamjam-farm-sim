using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hoverTip : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public string flowerName;
    private float waitTime = .3f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(startTimer());
        Debug.Log("hovered");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        hoverManager.OnMouseloseFocus();
    }

    private void showMessage()
    {
        //if statement to change text
        hoverManager.OnMouseHover(flowerName, Input.mousePosition);
    }

    private IEnumerator startTimer()
    {
        yield return new WaitForSeconds(waitTime);

        showMessage();
    }

}
