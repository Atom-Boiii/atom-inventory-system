using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    private bool hasItem;

    public BaseItem item;
    public Image icon;

    private MouseItem mouse;

    // Runs on the first frame
    private void Start()
    {
        mouse = FindObjectOfType<MouseItem>();
    }

    // Returns if the current itemframe has an item equipped
    public bool HasItem()
    {
        return hasItem;
    }

    //Sets the information nessecary for an item and sets the visual icon
    public void SetItem(BaseItem setItem)
    {
        item = setItem;

        Color itemColor = icon.color;
        itemColor.a = 1f;
        icon.color = itemColor;

        icon.sprite = setItem.icon;

        hasItem = true;
    }

    // This happens when the player clicks on a frame
    public void OnClick()
    {
        if (hasItem)
        {
            // if the frame has an item
            if(!mouse.HasItem())
            {
                // Clear the frame and put the item in the cursor box
                mouse.SetItem(item);

                Clear();
            }
            else
            {
                // Temporarily save the mouse item and put the frame item in the mouse
                // Then store the temp item in the frame

                BaseItem temp = mouse.item;

                mouse.SetItem(item);
                SetItem(temp);
            }
        }
        else if (!hasItem)
        {
            // if the frame has no item

            if (mouse.hasItem)
            {
                // Put the mouse item in the frame

                SetItem(mouse.item);
                mouse.Clear();
            }
        }
    }

    // Clear the frame by removing all information
    public void Clear()
    {
        item = null;

        Color itemColor = icon.color;
        itemColor.a = 0f;
        icon.color = itemColor;

        icon.sprite = null;

        hasItem = false;
    }
}
