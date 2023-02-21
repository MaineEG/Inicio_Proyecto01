using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float rapidezCaminar = 4f;
    // [SerializeField] private float velInicialDeSalto = 5.0f;
    [SerializeField] private float AlturaSalto = 5.0f;
    [SerializeField] private LayerMask capasSalto;

    private Rigidbody2D rb;
    private BoxCollider2D Boxcollider;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void MoverseEnX(float movimientoX)
    {
        rb.velocity = new Vector2(movimientoX * rapidezCaminar, rb.velocity.y);
    }

    public void Saltar(bool valor)
    {
        float velInicialDeSalto = Mathf.Sqrt(AlturaSalto * -2f * Physics2D.gravity.y * rb.gravityScale);
        if (!Boxcollider.IsTouchingLayers(capasSalto)) //Si toca alguna capa
        {
            return; 
        }


        if (valor)
        {
            rb.velocity = new Vector2( rb.velocity.x , velInicialDeSalto);
        }
       
    }

}
