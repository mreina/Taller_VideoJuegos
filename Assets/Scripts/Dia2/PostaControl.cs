using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostaControl : MonoBehaviour
{
    public float velocidad;

    public PostaControl()
    {
        this.velocidad = 10;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * ( Time.deltaTime * this.velocidad));

    }
}
