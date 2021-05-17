using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //Para usar Text como componente, temos que teclarar o UnityEngine.UI
    [SerializeField] Text textComponent;
    //Serialize Field permite modifica-lo no Unity


    // Start is called before the first frame update
    void Start()
    {
        //No componente textComponent estamos acessando a propriedade text
        textComponent.text = "This is our story text";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
