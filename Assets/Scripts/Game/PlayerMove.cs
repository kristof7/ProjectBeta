using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    private static bool playerExists;
    public Vector3 target;


    void Start()
    {
        target = transform.position;
        // Cheakd if player exist;
        if (playerExists)
        {
            Destroy(gameObject);
        }
        else
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    void Update()
    {

        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right button clicked");
        }

    }

}
