using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //Para usar Text como componente, temos que teclarar o UnityEngine.UI
    [SerializeField] Text textComponent;
    //Serialize Field permite modifica-lo no Unity
    [SerializeField] Text titleComponent;

    //criando um novo campo serializado no Unity
    [SerializeField] State startingState;

    //Instanciando a classe State
    State state;


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;

        //No componente textComponent estamos acessando a propriedade text
        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStoryTitle();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        //O visual studio entende que é um array de State
        var nextStates = state.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            state = startingState;
        }
        textComponent.text = state.GetStateStory();
        titleComponent.text = state.GetStoryTitle();
    }
}
