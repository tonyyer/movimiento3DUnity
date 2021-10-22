using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejes : MonoBehaviour
{
    // Propiedades necesarias
// Velocidad de giro del objeto
    float velAngular = 0.05f;
// Velocidad del objeto
    float velocidad= 0.005f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotamos de acuerdo al movimiento del eje horizontal
        transform.Rotate(0,velAngular*Input.GetAxis("Horizontal"),0);
        // Rotamos de acuerdo al movimiento vertical del eje
        transform.Translate(0,0,velocidad*Input.GetAxis("Vertical"));
        // Si se oprime el boton de disparo subimos el objeto
        if(Input.GetButtonDown("Fire1"))
        transform.Translate(0,0.5f,0);
    }
}
