using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class ControlJugador : MonoBehaviour
{
    // Obtener entradas del jugador

    private Movimiento movimiento;
    private Vector2 entradaControlMov;
    private LanzaProyectiles LanzaProyectiles;

    void Start()
    {
        movimiento = GetComponent<Movimiento>();
        LanzaProyectiles = GetComponent<LanzaProyectiles>();
    }

    
    void Update()
    {
        movimiento.MoverseEnX(entradaControlMov.x); 
    }

    public void AlMoverse (InputAction.CallbackContext context)
    {
        movimiento.VoltearTransform(entradaControlMov.x);
        entradaControlMov = context.ReadValue<Vector2>();
    }

    public void AlSaltar(InputAction.CallbackContext context)
    {
        movimiento.Saltar(context.action.triggered);
    }

    public void AlLanzar(InputAction.CallbackContext context)
    {
        if (!context.action.triggered) { return; }
        LanzaProyectiles.Lanzar();

    }
}
