using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
        private float r = 0.0f;
    private float g = 0.0f;
    private float b = 0.0f;
   private bool ortho = false;
   public Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        cam.farClipPlane=20.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Cambiamos el color del fondo
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
        // Seleccionamos un color al azar para
        // cada componente de color
        r = Random.value;
        g = Random.value;
        b = Random.value;
        // Creamos una variable de tipo color
        //// la incializamos con los valores de r,g,b

        // Asignamos el color al fondo
       
       //this.camera.backgroundColor=micolor;
        cam.backgroundColor = new Color(r, g, b);
        }

        // Cambiamos el modo ortografi co/perspectiva
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
        // Se hace un toggle a la variable
        ortho=!ortho;
        // Se asigna el nuevo estado a la camara
        cam.orthographic=ortho;
        }


        // Modifi camos el angulo de apertura de campo
        // Crea un efecto de zoom
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
        // Incrementamos la apertura de campo en 5 grados
        cam.fieldOfView+=5;
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
        // Reducimos la apertura de campo en 5 grados
        cam.fieldOfView-=5;
        }


        // Modifi camos la distancia del plano lejano
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
        // Alejamos el plano lejano
        cam.farClipPlane++;
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
        // Acercamos el plano lejano
        cam.farClipPlane--;
        }

    }
}
