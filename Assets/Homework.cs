using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Homework : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    Vector3 moveDir;

    private void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        moveDir.z = dir.y;
        if (dir.y < 0)
        {
            dir.x *= -1;
        }
        moveDir.x = dir.x;
    }

    private void Move()
    {
        transform.Translate(0, 0, moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime, Space.Self);
    }

    void Update()
    {
        Move();
        Rotate();
    }
}
