using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potsAndShelves : MonoBehaviour
{
    public GameObject[] pots;
    int boughtPots = 1;

    farmManager fm;
    // Start is called before the first frame update
    void Start()
    {
        fm = FindObjectOfType<farmManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyPot()
    {
        if(fm.money >= 50 && boughtPots < pots.Length)
        {
            fm.money -= 50;
            pots[boughtPots].gameObject.GetComponent<plotManager>().isActive = true;
            pots[boughtPots].gameObject.SetActive(true);
            boughtPots++;
            fm.moneyTxt.text = "$" + fm.money;
        }
        

    }
}
