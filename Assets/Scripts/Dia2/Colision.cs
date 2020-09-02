using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject textFin;
    /*
     * Método para personalizar la colisión de objetos.
     */
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //Me muero (cilindro)
        if (other.gameObject.name.Equals("jugador"))
        {
            Destroy(other.gameObject);
            //textFin.enabled = true;

        }
        else
        {
            Destroy(other.gameObject); //Se muere la posta

        }
    }
}
