﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, xMin, xMax), transform.position.y, transform.position.z);
    }
}
