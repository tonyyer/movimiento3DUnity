using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_LookAt : MonoBehaviour
{
    public Transform Box;
    void Update () {
        // Función para mirar hacia un objeto de la escena.
        transform.LookAt (Box);
    }
}
