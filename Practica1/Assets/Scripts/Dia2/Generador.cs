using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/*
 * Clase que permitira generar enemigos (Cilindros)
 */
public class Generador : MonoBehaviour
{
    public GameObject[] enemigos;
    private int randomEnemigos;
    private float rangoX = 4;
    private float tiempo;
// Update is called once per frame

    void Start()
    {
        InvokeRepeating("crearEnemigos",2,2);
    }

    void Update()
    {
        
    }

    /*
     * Método que permite generar enemigos al presionar la tecla Y
     */
    void crearEnemigos()
    {
     //   if (Input.GetKeyDown(KeyCode.Y))
       // {
            Vector3 posicion = new Vector3(Random.Range(-rangoX,rangoX),1.23f,4);
            randomEnemigos = Random.Range(0, enemigos.Length);
            Instantiate(enemigos[randomEnemigos], posicion,enemigos[randomEnemigos].transform.rotation);
        //}
    }
}
