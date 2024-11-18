using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CambiarEscenario(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void salir()
    {
        Application.Quit();
    }
}
