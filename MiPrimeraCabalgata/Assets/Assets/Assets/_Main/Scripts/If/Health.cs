using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour

{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int cura;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag ("Player"))
            {
            gameManager.SumarVida(10);

            Destroy (this.gameObject);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }



}
