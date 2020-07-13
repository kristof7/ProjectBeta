using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendorShop : MonoBehaviour
{

    public Item item;

    public void AttemtToBuyItem()
    {
        var Inventory = FindObjectOfType<Inventory>();
        var pick = FindObjectOfType<ItemPickUP>();
        int itemCost = item.GetDollarCost();
        // if we have enought Dollars
        if (Inventory.HaveEnoughDollars(itemCost))
        {
            Inventory.SpendDollars(itemCost);
            Inventory.instance.Add(item);
        }
    }
}
