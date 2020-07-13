using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPickUp : MonoBehaviour
{
    [SerializeField] public int dollars = 20;
    [SerializeField] Inventory DD;

    public void Start()
    {
        DD = FindObjectOfType<Inventory>();
    }

    public void AddDollars()
    {
        Destroy(gameObject);
        DD.AddDollars(dollars);
    }
}
