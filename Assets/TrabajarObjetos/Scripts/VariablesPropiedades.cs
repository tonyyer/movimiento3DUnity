using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesPropiedades : MonoBehaviour
{
    private float posX;
    private float posY;
    private float posZ;
    // Start is called before the first frame update
    void Start()
    {
        posX=1.5f;
        posY=-3.0f;
        posZ=-1.0f;
        transform.position = new Vector3(posX, posY, posZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
