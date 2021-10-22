using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionExplicita : MonoBehaviour
{
    // Este programa coloca la rotacion de un objeto
    // usando sus angulos de Euler por medio de los
    // valores de unas propiedades
    // Declaramos las propiedades
    float rotX = 30.0f;
    float rotY = 0.0f;
    float rotZ = 0.0f;
    void Start() {
    // Colocamos los angulos de Euler
    transform.eulerAngles = new Vector3(rotX, rotY, rotZ);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
