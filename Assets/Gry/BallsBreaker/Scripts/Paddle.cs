﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


    // Configuration Parameters

    [SerializeField] float screenWidthInUnits = 480f;
    [SerializeField] float MinX = -242f;
    [SerializeField] float MaxX = 242f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = Input.mousePosition.x/ Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2 (transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, MinX, MaxX);

        transform.position = paddlePos;
	}
}
