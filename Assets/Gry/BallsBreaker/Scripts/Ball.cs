using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 40f;
    [SerializeField] float yPush = 40f;
    [SerializeField] float randomFactor = 0.2f;
    [SerializeField] AudioClip[] ballSounds;
 

    // State

    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Cashed component references

    AudioSource myAudioSource;
    Rigidbody2D myrigidbody2D;

    // Use this for initialization
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
        myrigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockballToPaddle();
            LaunchOnMouseClick();
        }
        
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockballToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2 (Random.Range(0f, randomFactor),Random.Range (0f, randomFactor));
        if (hasStarted)
            {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
                GetComponent<AudioSource>().PlayOneShot(clip);
            myrigidbody2D.velocity += velocityTweak;
            }
    }
}
