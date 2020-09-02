using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindrosControl : MonoBehaviour
{
    
    public float velocidad;

    public CilindrosControl()
    {
        this.velocidad = 10;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * ( Time.deltaTime * this.velocidad));

    }
}
