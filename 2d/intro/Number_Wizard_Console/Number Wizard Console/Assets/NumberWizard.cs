using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    //Start acontece quando inicializamos a engine

    //declarar uma variavel D aqui ela será acessivel para ambos os métodos, será chamado variável de instância pois é acessivel a toda classe ou instância
    int max ;
    int min ;
    int guess ;
    void Start()
    {
        StartGame();

       
    }


    //Estrutura de função
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number wizard,yo");
        Debug.Log("Pick a number and don't tell me what it is");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Push ENTER = Correct");

        max++;
        min--;  
    }


    // Update is called once per frame
    // As variáveis do bloco de Codigo Start não são acessíveis ao bloco de Código Update, pois estão fora do escopo
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            
            min = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Your number is: " + guess);
            Debug.Log("PLAY AGAIN !");

            StartGame();
        }
        else if (guess + 1 == max || guess - 1 == min)
        {
            Debug.Log("Your number is: " + guess);
            Debug.Log("PLAY AGAIN !");

            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your guess higher (Press Up), lower (Press Down) or is equal to (Press Enter)  than " + guess + " ? ");
    }
    

}
