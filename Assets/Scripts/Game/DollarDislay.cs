using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarDislay : MonoBehaviour
{
    private Inventory inve;
    public Text dollarText;
    public GameObject GameManager;

    private void Start()
    {
        inve = FindObjectOfType<Inventory>();
    }

    //Spending Mechanizm that can be transfer to another Games

    private void Update()
    {
        dollarText.text = "$" + inve.dollars.ToString();
    }
}

