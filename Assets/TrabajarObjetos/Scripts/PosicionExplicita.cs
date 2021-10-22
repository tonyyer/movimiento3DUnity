using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionExplicita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var posicion =new Vector3(-2.5f, 2.0f, 2.0f);
        transform.position=posicion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
