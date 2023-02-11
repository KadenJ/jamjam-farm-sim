using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class farmManager : MonoBehaviour
{
    public plantItem selectPlant;
    public bool isPlanting = false;
    public int money = 1000;
    //public Text moneyTxt;
    public TextMeshProUGUI moneyTxt;

    private void Start()
    {
        moneyTxt.text = "$" + money;
    }

    public void SelectedPlant(plantItem newPlant)
    {
        if(selectPlant == newPlant)
        {
            Debug.Log("Deselected" + selectPlant.plant.plantName);
            selectPlant = null;
            isPlanting = false;
            
        }
        else
        {
            selectPlant = newPlant;
            Debug.Log("selected" + selectPlant.plant.plantName);
            isPlanting = true;
        }

        
    }
    public void Transaction(int value)
    {
        money += value;
        moneyTxt.text = "$" + money;
    }
}
