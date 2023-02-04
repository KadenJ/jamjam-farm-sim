using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hoverPlantTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string flowerTip;
    private float waitTime = .3f;

    //farmManager fm;

    private void Start()
    {
        //fm = FindObjectOfType<farmManager>();
    }

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
        hoverManager.OnMouseHover(/*fm.selectPlant.plant.plantName*/flowerTip, Input.mousePosition);
    }

    private IEnumerator startTimer()
    {
        yield return new WaitForSeconds(waitTime);

        showMessage();
    }
}

