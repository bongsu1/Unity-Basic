using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{
    public float movePower;
    public float rotateSpeed;
    public Rigidbody rigid;
    public float maxSpeed;

    Vector3 moveDir;

    void OnMove(InputValue value)
    {
        Vector2 vec2 = value.Get<Vector2>();
        moveDir.z = vec2.y;
        moveDir.x = vec2.x;
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Rotate();
    }

    void Move()
    {
        Vector3 forceDir = transform.forward * moveDir.z;
        rigid.AddForce (forceDir * movePower, ForceMode.Force);

        if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;
        }
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.World);
    }
}
