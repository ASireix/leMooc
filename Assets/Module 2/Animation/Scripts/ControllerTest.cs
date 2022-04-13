using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        if (!anim)
        {
            anim = GetComponent<Animator>();
        }
    }
    public void StartMoving()
    {
        anim.SetBool("isMoving", true);
    }

    public void StopMoving()
    {
        anim.SetBool("isMoving", false);
    }

    public void Shoot()
    {
        anim.SetTrigger("Shoot");
    }
}
