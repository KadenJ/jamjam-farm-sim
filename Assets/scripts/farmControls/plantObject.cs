using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plant")]

//only holds data
public class plantObject : ScriptableObject
{
    public string plantName;
    public Sprite[] plantStages;
    public float timeBetweenStages = 2f;

    public int buyPrice;
    public int sellPrice;
    public Sprite icon;

}
