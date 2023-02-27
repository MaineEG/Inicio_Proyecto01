using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private float rapidezCaminar = 4f;
    //[SerializeField] private float velInicialDeSalto = 5.0f;
    [SerializeField] private float alturaSaltoExtra = 1.0f;
    [SerializeField] private float numeroSaltosExtra = 1.0f;
    [SerializeField] private float AlturaSalto = 2.0f;
    [SerializeField] private LayerMask capasSalto;

    private Rigidbody2D rb;
    private BoxCollider2D boxcollider;
    private float SaltosHechos = 0; //contador
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ColisionSuelo();
    }
    
    public void MoverseEnX(float movimientoX)
    {
        rb.velocity = new Vector2(movimientoX * rapidezCaminar, rb.velocity.y);
    }

    public void Saltar(bool valor)
    {
        float gravedad = Physics2D.gravity.y * rb.gravityScale;
        float velInicialDeSalto = Mathf.Sqrt((-2 * gravedad * AlturaSalto));

        if (valor)
        {
            if (!boxcollider.IsTouchingLayers(capasSalto))
            {
                if (SaltosHechos < numeroSaltosExtra)
                {
                    rb.velocity = new Vector2(rb.velocity.x, Mathf.Sqrt((-2 * gravedad * alturaSaltoExtra)));
                    SaltosHechos += 1;
                }

            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, velInicialDeSalto);
            }
        }

    }

    public void VoltearTransform(float movimientoX)
    {
        transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x) * Mathf.Sign(movimientoX), transform.localScale.y);
    }

    public void ColisionSuelo()
    {
        if (boxcollider.IsTouchingLayers(capasSalto))
        {
            SaltosHechos = 0;
        }
    }


}
