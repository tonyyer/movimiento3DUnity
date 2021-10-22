using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPlaneta : MonoBehaviour
{
// Este programa rota al planeta alrededor de su propio eje
// Usamos valores aleatorios para la velocidad de rotacion
// Variable para la velocidad angular
private float velAngular;
    void Start()
    {
        // Se selecciona aleatoriamente un valor
        velAngular = Random.Range(-45,45);
    }
    void Update()
    {
        // Rotamos alrededor del eje Y
        transform.Rotate(0,velAngular*Time.deltaTime,0);
    }
}


