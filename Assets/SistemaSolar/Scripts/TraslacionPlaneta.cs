using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionPlaneta : MonoBehaviour
{
    private float velAngular;
    void Start()
    {
        // Colocamos un valor aleatorio
        velAngular = Random.Range(-80,80);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotamos alrededor del origen (0,0,0)
        // El eje de rotacion es up (Y)
        // Rotamos la cantidad indicada por velAngular y el tiempo transcurrido
        transform.RotateAround (Vector3.zero, Vector3.up, velAngular
        * Time.deltaTime);
    }
}

