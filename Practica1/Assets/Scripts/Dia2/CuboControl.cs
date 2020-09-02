using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class CuboControl : MonoBehaviour
{
    private float horizontal;
    [Range(1,50)]
    public float velocidad;
    private float limiteX = 7;
    public GameObject proyectil;
    public CuboControl()
    {
        this.velocidad = 10;
    }

    // Update is called once per frame
    void Update()
    {
        moverHorizontal();
        disparar();
    }

    /*
     * Método para mover el jugador de manera horizontal, con las flechas
     */
    void moverHorizontal()
    {
        this.horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontal * Time.deltaTime * this.velocidad));
        if (transform.position.x < -limiteX)
        {
            transform.position = new Vector3(-limiteX,transform.position.y,transform.position.z);
        }
        if (transform.position.x > limiteX)
        {
            transform.position = new Vector3(limiteX,transform.position.y,transform.position.z);
        }
    }

    /*
     * Método para disparar un proyectil
     */
    void disparar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectil, transform.position, proyectil.transform.rotation);
        }
    }

}
