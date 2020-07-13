using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField] int sceneNumber = 0;
    public GameObject MenuCanvas;
    [SerializeField] public GameObject player;
    [SerializeField] public float zPosition;

    public void LoadNewGameScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void LoadScenePlayerhide()
    {
        player = GameObject.Find("Player");
        SceneManager.LoadScene(sceneNumber);
        player.transform.position = new Vector3(transform.position.x, transform.position.x, zPosition);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


    public void OpenUI()
    {
        MenuCanvas.SetActive(!MenuCanvas.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}