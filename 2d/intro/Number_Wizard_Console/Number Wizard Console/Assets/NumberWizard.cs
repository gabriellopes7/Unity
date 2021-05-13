using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    //Start acontece quando inicializamos a engine

    //declarar uma variavel D aqui ela ser� acessivel para ambos os m�todos, ser� chamado vari�vel de inst�ncia pois � acessivel a toda classe ou inst�ncia
    int max = 1000;
    int min = 1;
    int guess = 500;
    void Start()
    {
        

        Debug.Log("Welcome to Number wizard,yo");
        Debug.Log("Pick a number and don't tell me what it is");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Push ENTER = Correct");
    }

    // Update is called once per frame
    // As vari�veis do bloco de Codigo Start n�o s�o acess�veis ao bloco de C�digo Update, pois est�o fora do escopo
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + guess) / 2;
           
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + guess) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Your number is: " + guess);
        }
        else if (guess + 1 == max || guess - min == min)
        {
            Debug.Log("Your number is: " + guess);
        }
    }
    
}
