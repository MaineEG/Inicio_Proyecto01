using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrpts : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private string mensaje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar ()
    {
        Debug.Log(mensaje);
    }
}
