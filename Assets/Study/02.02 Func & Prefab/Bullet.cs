using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    public float force;

    void Start()
    {
        Destroy(gameObject, 5f);
        rigid.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
