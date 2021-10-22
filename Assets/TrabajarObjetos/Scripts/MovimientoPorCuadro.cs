using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPorCuadro : MonoBehaviour
{
    float avance = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(avance,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
