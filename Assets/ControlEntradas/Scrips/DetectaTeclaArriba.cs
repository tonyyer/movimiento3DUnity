using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaTeclaArriba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Con esta funcion controlamos el movimiento del objeto
    // por medio de las teclas de fl echas
    // Solo se lleva a cabo la accion en el momento que se suelta la tecla
    void Update()
    {
        // Verifi camos si se ha soltado la tecla fl echa derecha
        if(Input.GetKeyUp(KeyCode.RightArrow))
        transform.Rotate(0,5,0);
        // Verifi camos si se ha soltado la tecla fl echa izquierda
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        transform.Rotate(0,-5,0);
        // Verifi camos si se ha soltado la tecla fl echa arriba
        if(Input.GetKeyUp(KeyCode.UpArrow))
        transform.Translate(0,0,1);
    }
}
