using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPorCuerpo : MonoBehaviour
{
    float velocidad = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,velocidad*Time.deltaTime);
    }
}
