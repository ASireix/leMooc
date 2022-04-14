using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    bool isAiming;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed && isAiming)
        {
            anim.SetTrigger("Shoot");
        }
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        if (context.started && !isAiming)
        {
            anim.SetTrigger("Aim");
            anim.SetBool("isAiming", true);
            isAiming = true;
        }


        if (context.canceled)
        {
            anim.SetBool("isAiming", false);
            isAiming = false;
        }

    }
}
