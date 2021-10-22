using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesMouse : MonoBehaviour
{
    // Propiedades necesarias
    // Velocidad del objeto
    float velocidad  = 50.0f;
    void Start()
    {
        
    }

    // Al oprimir los botones del mouse se controla la
// orientacion del objeto
    void Update()
    {
        // Verifi camos si se oprime el boton izquierdo
        if(Input.GetMouseButton(0))
        transform.Rotate(0,velocidad*Time.deltaTime,0);
        // Verifi camos si se oprime el boton central
        if(Input.GetMouseButton(1))
        transform.Rotate(velocidad*Time.deltaTime,0,0);
        // Verifi camos si se oprime el boton derecho
        if(Input.GetMouseButton(2))
        transform.Rotate(0,-velocidad*Time.deltaTime,0);
    }
}
