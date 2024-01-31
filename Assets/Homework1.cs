using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    [SerializeField] Transform transform;
    [SerializeField] float moveSpeed;

    [SerializeField] Rigidbody rigid;
    [SerializeField] float jumpPower;

    [SerializeField] float jumpCool;
    [SerializeField] bool canJump;

    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += moveSpeed * Time.deltaTime;
        }

        transform.position = pos;

        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            StartCoroutine(JumpCoolTime());
        }
    }

    IEnumerator JumpCoolTime()
    {
        canJump = false;
        Debug.Log("점프 불가능");
        yield return new WaitForSeconds(jumpCool);
        Debug.Log("점프 가능");
        canJump = true;
    }
}
