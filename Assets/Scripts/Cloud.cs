using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [Range(0f, 1000f)] [SerializeField] float currentSpeed = 1f;
    GameObject currentTarget;


    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float Speed)
    {
        currentSpeed = Speed;
    }
}
