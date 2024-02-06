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
    public Animator animator;

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
        Bullet bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.force = bulletForce < 5f ? 10f : bulletForce;
        shootSound.Play();
        animator.SetTrigger("Fire");
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
