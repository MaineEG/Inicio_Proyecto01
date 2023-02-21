using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class ControlJugador : MonoBehaviour
{
    // Obtener entradas del jugador

    private Movimiento movimiento;
    private Vector2 entradaControlMov; 

    void Start()
    {
        movimiento = GetComponent<Movimiento>();
    }

    
    void Update()
    {
        movimiento.MoverseEnX(entradaControlMov.x); 
    }

    public void AlMoverse (InputAction.CallbackContext context)
    {
        entradaControlMov = context.ReadValue<Vector2>();
    }

    public void AlSaltar(InputAction.CallbackContext context)
    {
        movimiento.Saltar(context.action.triggered);
    }
}
