using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newInventoryItem", menuName = "ScriptableObject/Item")]
public class InventoryData : ScriptableObject
{
    public List<InventoryItems> itemsInInventory;
}
[System.Serializable]
public class InventoryItems 
{
    public FlowerData slotItem;
    public bool seedOrFlower;
    public int countInSlot;
}
