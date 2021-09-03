using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("InventoryObjects")]
    public int inventorySize;
    public Vector2 minmaxInventorySize;

    [Header("Inventory objects")]
    public GameObject inventoryItem;
    public Transform frameGrid;

    private int currentSize;
    private List<GameObject> inventoryItems = new List<GameObject>();

    // Runs on the first frame
    private void Start()
    {
        UpdateInventorySize();
    }

    // Updates the size of the inventory when nessecary
    private void UpdateInventorySize()
    {
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            Destroy(inventoryItems[i]);
        }

        inventoryItems.Clear();

        for (int x = 0; x < inventorySize; x++)
        {
            GameObject tempInvItem = Instantiate(inventoryItem, frameGrid);
            inventoryItems.Add(tempInvItem);
        }

        currentSize = inventorySize;
    }

    // Increases the inventory size
    public void IncreaseSize()
    {
        if(inventorySize < minmaxInventorySize.y)
        {
            inventorySize++;
            UpdateInventorySize();
        }
    }

    // Adds an item to the inventory. It takes a base item which has all information stored
    public void AddItem(BaseItem itemName)
    {
        foreach(GameObject item in inventoryItems)
        {
            if(item.GetComponent<InventoryItem>().HasItem() == false)
            {
                item.GetComponent<InventoryItem>().SetItem(itemName);
                break;
            }
        }
    }

    // Removes all items fron the inventory
    public void ClearInventory()
    {
        foreach(GameObject item in inventoryItems)
        {
            item.GetComponent<InventoryItem>().Clear();
        }

        // TODO: Drop items
    }
}
