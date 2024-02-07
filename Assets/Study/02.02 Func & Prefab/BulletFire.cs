using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class BulletFire : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] float bulletForce;

    public UnityEvent OnFired;
    public UnityEvent OnFiring;

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

    public void Fire() 
    {
        OnFiring?.Invoke();

        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce < 5f ? 10f : bulletForce;
        Manager2.Data.ChargedPower = bulletForce;

        OnFired?.Invoke();
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
