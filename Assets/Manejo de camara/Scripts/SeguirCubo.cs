using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCubo : MonoBehaviour
{
    public Transform objetivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotamos la camara en direccion al objetivo
        transform.LookAt(objetivo);             
    }
}
