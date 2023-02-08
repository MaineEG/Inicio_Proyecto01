using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCuadrado : MonoBehaviour
{

    private Scrpts hello;

    // Start is called before the first frame update

    void Start()
    {
        hello = GetComponent<Scrpts>();
        hello.Saludar();

        // Update is called once per frame
    }
    void Update()
    {
        
    }
}
