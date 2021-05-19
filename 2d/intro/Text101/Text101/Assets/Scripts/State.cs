using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;

    [TextArea(5, 1)] [SerializeField] string storyTitle;
    

    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public string GetStoryTitle()
    {
        return storyTitle;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
