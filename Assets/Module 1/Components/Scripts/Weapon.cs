using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float POWER;

    public Transform shootingPos;

    public float activeTime;
    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject tempBullet = Instantiate(bulletPrefab, shootingPos.position, shootingPos.rotation);
            tempBullet.GetComponent<Bullet>().Launch(shootingPos.forward, POWER);
            Destroy(tempBullet, activeTime);
        }
        
    }
}
