using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestsRotations : MonoBehaviour{
    public float DegreePerSecond = 30;
    
    void Update(){
        transform.localEulerAngles += Vector3.up * DegreePerSecond * Time.deltaTime;
    }
}
