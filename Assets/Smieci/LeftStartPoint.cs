using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftStartPoint : MonoBehaviour
{

    private PlayerMove thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerMove>();
        thePlayer.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
