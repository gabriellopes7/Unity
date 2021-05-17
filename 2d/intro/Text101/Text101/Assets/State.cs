using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;


[CreateAssetMenu(menuName="State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;


}
