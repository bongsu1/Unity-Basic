using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletFire : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] float bulletForce;
    

    float chargedTime;
    Coroutine charge;

    void OnFire(InputValue value)
    {
        
        if (value.isPressed)
        {
            chargedTime = 0f;
            charge = StartCoroutine(Charge());
        }
        else
        {
            StopCoroutine(charge);
            Fire();
        }
    }

    void Fire() 
    {
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce + chargedTime;
    }

    IEnumerator Charge()
    {
        while (true)
        {
            chargedTime += Time.deltaTime * 10;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
