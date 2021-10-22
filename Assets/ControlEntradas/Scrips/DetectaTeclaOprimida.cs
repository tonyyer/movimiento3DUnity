using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaTeclaOprimida : MonoBehaviour
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
    // Controlamos la orientacion
    // Verifi camos si se ha oprimido la tecla fl echa derecha
    if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
    transform.Rotate(0,velAngular*Time.deltaTime,0);
    // Verifi camos si se ha oprimido la tecla fl echa izquierda
    if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
    transform.Rotate(0,-velAngular*Time.deltaTime,0);
    // Verifi camos si se ha oprimido la tecla fl echa arriba
    if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
    transform.Translate(0,0,velocidad*Time.deltaTime);
    
    if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
    transform.Translate(0,0,-velocidad*Time.deltaTime);
    }
}
