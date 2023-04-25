using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour

{
    [SerializeField] private int IndiceEscena;
    public void IniciarJuego()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CerrarAplicacion()

    {
        Application.Quit();

    }

}