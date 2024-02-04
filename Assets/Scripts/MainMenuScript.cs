using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void IrASeleccionDeNivel()
    {
        SceneManager.LoadScene("NivelSeleccion");
    }

    public void IrACreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
