using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelSeleccionScript : MonoBehaviour
{
    public void IrNivel1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void IrNivel2()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void VolverAlPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
