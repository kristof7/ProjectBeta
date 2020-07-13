using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public GameObject MenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("MENU"))
        {
            MenuCanvas.SetActive(!MenuCanvas.activeSelf);
        }
    }
}
