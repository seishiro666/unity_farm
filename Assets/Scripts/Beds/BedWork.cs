using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Empty,
    SeedPlanted,
    Sprout,
    MaturePlant,
    Harvest,
    End
}

public class BedWork : MonoBehaviour
{
    public static Action<string, int> onBedClick;
    [SerializeField] State currentState = State.Empty;
    [SerializeField] GameObject flowerPos;

    FlowerData flowerData;
    InventoryItem flowerItemData;
    GameObject flowerObj;
    List<GameObject> flowersList = new List<GameObject>();
    [SerializedField] bool haveSeed = false;
    GameObject bedSlot;
    GameObject itemPrefab;
    InventoryController inventoryController;
    InventorySystem inventorySystem;

    public void SetupBed()
    {
        if (currentState = State.Empty)
        {
            onBedClick?.Invoke(0);
            OnSetup()
        }

        else if (currentState = State.MaturePlant)
        {
            CollectSeeds();
            inventorySystem = null;
            SwapState();
        }

        else if (currentState = State.End)
        {
            CollectFlowers();
            ClearBed();
        }
    }

    public void StartGrowth(InventoryItem itemData, GameObject bedSlotUI, InventoryController invController )
    {
        inventoryController = intController;
        flowerItemData = itemData;
        flowerData = flowerItemData.flowerData;
        bedSlot = bedSlotUI;

        if (itemData.ItemCount >= 4)
        {
            itemData.ItemCount -= 4;

            if (itemData.ItemCount <= 0)
            {
                inventoryController.inventory.inventorySystem.Remove(itemData.GetInventorySystemData());
                itemData.ClearSlot();
            }

            else
            {
                itemData.RefreshItem(itemData.ItemCount);
            }

            flowerObj = flowerData.model;

            for (int i = 0; i < 4; i++)
            {
                GameObject tempFlower = Instantiate(flowerObj, flowerPos.transform.GetChild(i));
                flowersList.Add(tempFlower);
            }
            
            currentState = State.SeedPlanted;

            OnEndSetup();

            StartCoroutine(StartGrowthProcess(itemData));
        }
    }
}
