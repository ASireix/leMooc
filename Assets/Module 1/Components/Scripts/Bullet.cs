using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody body;
    

    

    public void Launch(Vector3 direction, float puissance)
    {
        body = GetComponent<Rigidbody>();
        body.AddForce(direction * puissance);
    }
}
