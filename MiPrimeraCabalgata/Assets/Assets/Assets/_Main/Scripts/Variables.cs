using UnityEngine;
using TMPro; 

public class Variables : MonoBehaviour
{
    //Declarar variables 

    public string myName = "Juan";
    public int _edad = 17;
    public bool isBool; 



    [SerializeField] private TMP_InputField _imputfield;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _boxCollider;


     void Start()
    {
        _cubo.material.color = Color.red;
        _boxCollider.isTrigger = false; 

    }

    // Update is called once per frame
    void Update()
    {
        myName = _imputfield.text;
        _saludo.text = "saludos" + myName;
    }
}
