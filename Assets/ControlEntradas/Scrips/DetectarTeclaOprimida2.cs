using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarTeclaOprimida2 : MonoBehaviour
{
 // Propiedades necesarias
    // Velocidad del objeto
    // Velocidad de rotacion
    float velocidad =1.0f;
    float velAngular =45.0f;

    void Start()
    {
        
    }

    // Con esta funcion controlamos el movimiento del objeto
// por medio de las teclas de fl echas
// La accion se lleva a cabo todo el tiempo que la tecla este
// oprimida
    void Update()
    {

    if(Input.GetKey(KeyCode.Space))
    velocidad=velocidad+1;

    if(Input.GetKey(KeyCode.LeftControl))
    velocidad=velocidad-1;

    if(Input.GetKey(KeyCode.Keypad6))
    transform.Rotate(0,velAngular*Time.deltaTime,0);

    if(Input.GetKey(KeyCode.Keypad4))
    transform.Rotate(0,-velAngular*Time.deltaTime,0);

    if(Input.GetKey(KeyCode.Keypad8))
    transform.Translate(0,0,velocidad*Time.deltaTime);
    
    if(Input.GetKey(KeyCode.Keypad5))
    transform.Translate(0,0,-velocidad*Time.deltaTime);
    }
}
