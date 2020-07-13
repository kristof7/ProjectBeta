using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class NextScene : MonoBehaviour
{

    [SerializeField] int sceneNumber = 0;
    [SerializeField] public float xPosition;
    [SerializeField] public float yPosition;
    [SerializeField] public float zPosition;
    [SerializeField] public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            StartCoroutine("Wait");
            Debug.Log("Q1");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        Debug.Log("Q2");
        NewScene();
    }

    private void NewScene()
    {
        SceneManager.LoadScene(sceneNumber);
        OnsceneLoaded();
    }

    private void OnsceneLoaded()
    {
        player.transform.position = new Vector3(xPosition, yPosition, zPosition);
        player.GetComponent<PlayerMove>().target = player.transform.position;
        Debug.Log("Q3");
    }
}