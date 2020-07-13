using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    [TextArea(10,14)] [SerializeField] string TextFile1;
    [SerializeField] State[] nextStates;
		
    public string GetStateStory()
    {
        return TextFile1;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}

