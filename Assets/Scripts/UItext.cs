using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UItext : MonoBehaviour
{
    [SerializeField] GameObject Text;

    private void Start()
    {
        Text.SetActive(false);
    }

    public void UIText()
    {
        Text.SetActive(true);
    }
}