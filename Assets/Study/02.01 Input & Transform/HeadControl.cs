using UnityEngine;
using UnityEngine.InputSystem;

public class HeadControl : MonoBehaviour
{
    [SerializeField] Transform head;
    [SerializeField] float rotateSpeed;
    [SerializeField] float angleSpeed;

    Vector3 rotate;

    void OnHeadRotate(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        rotate.x = input.x;
        rotate.y = -input.y;
    }

    void Rotate()
    {
        head.Rotate(Vector3.up, rotate.x * rotateSpeed * Time.deltaTime, Space.World);
        head.Rotate(Vector3.right, rotate.y * angleSpeed * Time.deltaTime);
    }

    void Update()
    {
        Rotate();
    }
}
