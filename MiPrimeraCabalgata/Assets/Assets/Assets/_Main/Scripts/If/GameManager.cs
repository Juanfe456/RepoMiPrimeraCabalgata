using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int vidaJugador = 100;
    


    public void SumarVida(int cura) 
    {

        if (vidaJugador < 100) 
        {
            vidaJugador += cura; 
        
        }
        else
        {
            vidaJugador = 100;
            Debug.Log("no cura");
        }

   
    }


    public void RestarVida(int dano)
    {
        vidaJugador -= dano;

        if ( vidaJugador <= 0)
        {
       
            Debug.Log("Game Over");



            Debug.Log("Jugador Muerto");

            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }



    
        
        
    
}







