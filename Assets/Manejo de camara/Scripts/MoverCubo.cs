using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    float velocidad =15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si oprimimos la tecla fl echa derecha
        if(Input.GetKey(KeyCode.RightArrow))
        {
        // Trasladamos el cubo
        transform.Translate(velocidad*Time.deltaTime,0,0);
        }
        // Si oprimimos la tecla fl echa izquierda
        if(Input.GetKey(KeyCode.LeftArrow))
        {
        // Trasladamos el cubo
        transform.Translate(-velocidad*Time.deltaTime,0,0);
        }
    }
}
