using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPorTiempo : MonoBehaviour
{
// Este programa rota un objeto determinados grados por segundo
// alrededor del eje X, usando el valor de una propiedad
    float velAngular = 15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotamos determinados grados por segundo en el eje X
        // No hay rotacion en los otros dos ejes
        transform.Rotate(velAngular*Time.deltaTime,0,0);
    }
}
