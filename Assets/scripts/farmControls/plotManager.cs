using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plotManager : MonoBehaviour
{
    bool isPlanted = false;
    public SpriteRenderer plant;
    BoxCollider2D plantCollider;

    int plantStage = 0;
    float timer;

    plantObject selectedPlant;
    farmManager FM;
    // Start is called before the first frame update
    void Start()
    {
        FM = transform.parent.GetComponent<farmManager>();
        plant = transform.GetChild(0).GetComponent<SpriteRenderer>();
        plantCollider = transform.GetChild(0).GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlanted)
        {
            timer -= Time.deltaTime;

            if (timer < 0 && plantStage < selectedPlant.plantStages.Length - 1)
            {
                timer = selectedPlant.timeBetweenStages;
                plantStage++;
                UpdatePlant();
            }
        }

        
    }

    private void OnMouseDown()
    {
        if (isPlanted)
        {
            if(plantStage == selectedPlant.plantStages.Length - 1 /*&& !FM.isPlanting*/)
            {
                harvest();
            }
            
        }
        else if(FM.isPlanting&&FM.selectPlant.plant.buyPrice <= FM.money)
        {
            plantCrop(FM.selectPlant.plant);
        }

    }

    void harvest()
    {
        Debug.Log("harvested");
        isPlanted = false;
        plant.gameObject.SetActive(false);

        FM.Transaction(+selectedPlant.sellPrice);
    }

    void plantCrop(plantObject newPlant)
    {
        selectedPlant = newPlant;
        Debug.Log("plant crop");
        isPlanted = true;

        FM.Transaction(-selectedPlant.buyPrice);
        plantStage = 0;
        UpdatePlant();
        timer = selectedPlant.timeBetweenStages;
        plant.gameObject.SetActive(true);
    }

    void UpdatePlant()
    {
        plant.sprite = selectedPlant.plantStages[plantStage];
        plantCollider.size = plant.sprite.bounds.size;
        plantCollider.offset = new Vector2(0, plant.bounds.size.y / 2);
    }
}
