using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeadControl : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    Vector3 rotate;

    void OnHeadRotate(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        rotate.x = input.x;
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up, rotate.x *  rotateSpeed * Time.deltaTime);
    }

    void Update()
    {
        Rotate();
    }
}
