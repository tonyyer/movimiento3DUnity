using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarTecla : MonoBehaviour
{
    // Con esta funcion controlamos el movimiento del objeto
// por medio de las teclas de fl echas
// Solo se lleva a cabo la accion en el momento en que se oprime la tecla
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifi camos si se ha oprimido la tecla fl echa derecha
        if(Input.GetKeyDown(KeyCode.RightArrow))
        transform.Rotate(0,5,0);
        // Verifi camos si se ha oprimido la tecla fl echa izquierda
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        transform.Rotate(0,-5,0);
        // Verifi camos si se ha oprimido la tecla fl echa arriba
        if(Input.GetKeyDown(KeyCode.UpArrow))
        transform.Translate(0,0,1);
    }
}
