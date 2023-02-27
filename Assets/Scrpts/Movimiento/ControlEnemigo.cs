using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    [SerializeField] private Transform detector;
    [SerializeField] private float distanciaAlSuelo = 0.3f;
    [SerializeField] private LayerMask layerSuelo;

    private Movimiento movimiento;
    Vector2 direccionMovimiento;


    void Start()
    {
        movimiento = GetComponent<Movimiento>();
        direccionMovimiento = new Vector2(1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        movimiento.VoltearTransform(direccionMovimiento.x);
        movimiento.MoverseEnX(direccionMovimiento.x);
        DetectarSuelo();
    }

    private void DetectarSuelo()
    {
        RaycastHit2D raycast = Physics2D.Raycast(detector.position, Vector2.down, distanciaAlSuelo, layerSuelo);
        if (raycast.collider == null)
        {
            direccionMovimiento.x *= -1f;
        }
    }
}
