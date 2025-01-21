using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; 
[CreateAssetMenu(fileName = "newflower", menuName ="ScriptableObject/flower")]
public class FlowerData : ScriptableObject
{
    public string flowerName;
    public int flowerPrice;
    public float flowerRiseTime;
    public float seedRiseTime;
    public Sprite flowerIcon;
    public Sprite seedIcon;
    public int awardForFlower;
    public GameObject flowerModel;
}
