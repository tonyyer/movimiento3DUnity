using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBasico : MonoBehaviour
{

    // Propiedades necesarias
    // Velocidad de la camara
    float velocidad = 5.0f;
    // Velocidad de giro de la camara
    float velAngular =45.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifi camos si avanza la camara
        if(Input.GetKey(KeyCode.UpArrow))
        {
        // Trasladamos en el eje Z
        transform.Translate(0,0,velocidad*Time.deltaTime);
        }
        // Verifi camos si retrocedemos
        if(Input.GetKey(KeyCode.DownArrow))
        {
        // Trasladamos en el eje Z
        transform.Translate(0,0,-velocidad*Time.deltaTime);
        }

        // Verifi camos por giro a la derecha
        if(Input.GetKey(KeyCode.RightArrow))
        {
        // Rotamos en el eje Y
        transform.Rotate(0,velAngular*Time.deltaTime,0);
        }
        // Verifi camos por giro a la izquierda
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        // Rotamos en el eje Y
        transform.Rotate(0,-velAngular*Time.deltaTime,0);
        }

    }
}
