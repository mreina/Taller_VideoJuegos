using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    private String nombre;
    
    //Asociar a teclas
    public float horizontal;
    public float adelante;
    public float salto;
    public float fuerza;

    //Propiedades
    public int velocidad;
    public int velocidadGiro;
    
    void Start()
    {
        this.nombre = "Cubo";
    }

    // Update is called once per frame
    void Update()
    {
        //Asignar teclas
        this.salto = Input.GetAxis("Jump");
        this.horizontal = Input.GetAxis("Horizontal");
        this.adelante = Input.GetAxis("Vertical");
        moverAdelante();
        moverDerecha();
        moverSalto();
        /*
            if (Input.GetKey((KeyCode.Y)))
            {
                moverAdelante();
            }
        */
    }

    void moverAdelante()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * this.adelante* this.velocidad));

    }

    void moverDerecha()
    {
        transform.Rotate((Vector3.up * (Time.deltaTime * this.horizontal * this.velocidadGiro)));

    }

    void moverSalto()
    {
        transform.Translate((Vector3.up * (Time.deltaTime * fuerza * salto)));

    }
}
