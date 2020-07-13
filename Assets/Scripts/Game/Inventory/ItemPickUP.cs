using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUP : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUP();
    }

    public void PickUP()
    {
        Debug.Log("Picking up" + item.name);
        // Add to inventory
        bool wasPickedUp = Inventory.instance.Add(item);

        if(wasPickedUp)
        {
            Destroy(gameObject);
        }
    }
}
