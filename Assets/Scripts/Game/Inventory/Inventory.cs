using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public int dollars = 100;
    private static bool invExists;

    private void Start()
    {
        if (invExists)
        {
            Destroy(gameObject);
        }
        else
        {
            invExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    #region Singleton

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;

    public int space = 20;

    public List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("Not enough room");
                return false;
            }
            items.Add(item);

            if(onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
        }
        return true;
    }

    public void Remove (Item item)
    {
        items.Remove(item);
    }

    public bool HaveEnoughDollars(int amount)
    {
        return dollars >= amount;
    }

    public void AddDollars(int amount)
    {
        dollars += amount;

    }

    public void SpendDollars(int amount)
    {
        if (dollars >= amount)
        {
            dollars -= amount;
        }
    }
}
