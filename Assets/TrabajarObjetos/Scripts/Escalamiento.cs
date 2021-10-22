using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalamiento : MonoBehaviour
{
    // Variable para la escala
    private float escalaActual = 1.0f;

    // Propiedad para la velocidad de escala
    private float velEscala = 0.75f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Actualizamos el valor de escala
        escalaActual=escalaActual+(velEscala*Time.deltaTime);
        // Cambiamos la escala, la misma en todos los ejes
        transform.localScale=new Vector3(escalaActual,escalaActual,escalaActual);
        // Verifi camos si llega a su limite superior
        if(escalaActual>2.0)
        {
        // Hacemos trim al valor
        escalaActual=2.0f;
        // Invertimos la direccion del cambio de escala
        velEscala*=-1.0f;
        }
        // Verifi camos si llega a su limite inferior
        if(escalaActual<0.5)
        {
        // Hacemos trim al valor
        escalaActual=0.5f;
        // Invertimos la direccion del cambio de escala
        velEscala*=-1.0f;
        }

    }
}
