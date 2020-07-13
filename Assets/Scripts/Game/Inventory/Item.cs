using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inv")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    [SerializeField] int dollarCost = 100;
    public bool isDefaultItem = false;
    public virtual void Use ()
    {
        //Use Item, somthing can happen
        Debug.Log("Using" + name);
    }
    public int GetDollarCost()
    {
        return dollarCost;
    }
}
