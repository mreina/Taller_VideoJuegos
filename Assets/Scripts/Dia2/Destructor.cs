using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    private readonly float limiteSuperior;
    private readonly float limiteInferior;
    public Destructor()
    {
        this.limiteSuperior = 10;
        this.limiteInferior = -9;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > this.limiteSuperior)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < this.limiteInferior)
        {
            Destroy(gameObject);
        }
    }
}
