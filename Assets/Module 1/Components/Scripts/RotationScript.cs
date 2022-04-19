using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10f,5f,0f,Space.World);
    }
}
