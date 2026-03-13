using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour



{
    // [SerializeField] bool _sillueve = false;
    //[SerializeField] private int _edad;
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private bool isGround;
    [SerializeField] private float moveSpeed = 5f;
   

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    private void Update()
    {

        if (Input.GetButtonDown("Jump") && isGround)

        {
            _rb2d.AddForce(Vector2.up * fuerzaSalto);


        }


    }

    private void FixedUpdate()
    {
       

        float moveInput = Input.GetAxis("Horizontal");
        _rb2d.linearVelocity = new Vector2(moveInput * moveSpeed, _rb2d.linearVelocity.y);

        float moveInput2 = Input.GetAxis("Horizontal");
        _rb2d.linearVelocity = new Vector2(moveInput * moveSpeed, _rb2d.linearVelocity.y);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            isGround = true;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
































}

















