using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class menu : MonoBehaviour
{
	
public float buttonWidth = 300;
public float buttonHeight = 60; 
private float buttonMargin = 20;
    // Start is called before the first frame update
    void OnGUI()
    {
		if(GUI.Button(new Rect (300, 300, buttonWidth, buttonHeight), "New Game")) {
 
}
if(GUI.Button(new Rect (300, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "Options")) {
}
if(GUI.Button(new Rect (300, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "Exit")) {
}

if(GUI.Button(new Rect (300, 300, buttonWidth, buttonHeight), "New Game")) {
Application.LoadLevel("Game");
}
if(GUI.Button(new Rect (300, 300 + buttonHeight + buttonMargin, buttonWidth, buttonHeight), "Options")) {
}
if(GUI.Button(new Rect (300, 300 + (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "Exit")) {
Application.Quit();
}
        
    }

   
}
