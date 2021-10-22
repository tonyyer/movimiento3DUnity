using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Move : MonoBehaviour
{
    public Transform Box;
    void Update () {
        transform.position = new Vector3
        (Box.position.x, transform.position.y, Box.position.z);
    }

}
