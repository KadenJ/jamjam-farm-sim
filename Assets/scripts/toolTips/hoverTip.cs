using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hoverTip : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public plantObject plant;
    public farmManager FM;
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
        if (plant.buyPrice > FM.money)
        {
            hoverManager.OnMouseHover("not enough money", Input.mousePosition);
        }
        else
        {
            hoverManager.OnMouseHover(flowerName, Input.mousePosition);
        }
        //if statement to change text
        
    }

    private IEnumerator startTimer()
    {
        yield return new WaitForSeconds(waitTime);

        showMessage();
    }

}
