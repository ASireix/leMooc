using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    [SerializeField] float fall_timer = 3f;
    [SerializeField] float reset_timer = 8f;
    private float fall_time = 0f, reset_time = 0f;
    private bool time_running1 = false, time_running2 = false;
    private Rigidbody rb;
    private Vector3 origin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        origin = transform.position;
    }

    void Update(){
        if(time_running1){
            fall_time += Time.deltaTime;
            if(fall_time >= fall_timer){
                rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
                time_running1 = false;
                fall_time = 0f;
                reset_time = 0f;
            }
        }
        if(time_running2){
            reset_time += Time.deltaTime;
            if(reset_time >= reset_timer){
                rb.constraints = RigidbodyConstraints.FreezeAll;
                time_running2 = false;
                transform.position = origin;
                fall_time = 0f;
                reset_time = 0f;
            }
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.layer == 3){
            if(!time_running2){
                time_running2 = true;
                print("ground hit");
            }
        }
        else{
            if(!time_running1){
                time_running1 = true;
                print("something hit the plateform");
            }
        }
    }
}
