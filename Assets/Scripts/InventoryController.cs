using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static Inventory Instance { get; private set; }
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItems(List<Item> itemsToAdd)
    {
        items.AddRange(itemsToAdd);
        UIManager.Instance.UpdateInventoryUI();
    }

    public void RemoveSeeds(Seed seed, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Item itemToRemove = null;
            foreach (Item item in items)
            {
                if (item.type == Item.ItemType.Seed && item.seed == seed)
                {
                    itemToRemove = item;
                    break;
                }
            }
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
            }
            else
            {
                Debug.LogWarning($"{seed.seedName} нет в инвентаре");
            }
        }
        UIManager.Instance.UpdateInventoryUI();
    }
}