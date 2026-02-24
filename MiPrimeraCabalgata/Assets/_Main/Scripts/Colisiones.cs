using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour


{
   void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Estoy tocando algo");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Estoy tocando algo");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Estoy tocando algo");
    }
}
