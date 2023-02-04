using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plantItem : MonoBehaviour
{
    public plantObject plant;
    public Text nameTxt;
    public Text priceTxt;
    public Image icon;

    farmManager FM;

    private void Start()
    {
        FM = FindObjectOfType<farmManager>();

        InitializeUI();


    }

    public void buyPlant()
    {
        Debug.Log("bought" + plant.plantName);
        FM.SelectedPlant(this);
        
    }

    void InitializeUI()
    {
        nameTxt.text = plant.plantName;
        priceTxt.text = "$" + plant.buyPrice;
        icon.sprite = plant.icon;
    }
}
