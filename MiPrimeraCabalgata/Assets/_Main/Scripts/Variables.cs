using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declarar variables 

    string myName = "Juan";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola" + myName);
        
    }

    // Update is called once per frame
    void Update()
    {
         Debug.Log("Hola" + myName); 
    }
}
