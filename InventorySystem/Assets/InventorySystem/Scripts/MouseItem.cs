using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseItem : InventoryItem // This script inherits from InventoryItem because it is nearly the same
{
    // This runs every frame
    private void Update()
    {
        // Set it to the mouse position
        transform.position = Input.mousePosition;

        // Remove the item from the mouse
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            Clear();
        }
    }
}
