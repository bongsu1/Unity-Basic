using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletFire : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] float bulletForce;
    public AudioSource shootSound;

    Coroutine charge;

    void OnFire(InputValue value)
    {
        
        if (value.isPressed)
        {
            bulletForce = 0f;
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
        bullet.force = bulletForce;
        shootSound.Play();
    }

    IEnumerator Charge()
    {
        while (true)
        {
            bulletForce += Time.deltaTime * 10;
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
