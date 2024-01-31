using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour
{
    [SerializeField] float jumpPower;
    [SerializeField] Rigidbody rigid;
    [SerializeField] bool canJump;
    
    enum JumpMode { Delay, Trple, Push}
    [SerializeField] JumpMode mode; 

    void Update()
    {
        if (canJump && mode == JumpMode.Delay && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = false;
            StartCoroutine(DelayJump());
        }
        else if(canJump && mode == JumpMode.Trple && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = false;
            StartCoroutine(TripleJump());
        }
        else if (canJump && mode == JumpMode.Push && Input.GetKey(KeyCode.Space)) 
        {
            canJump = false;
            StartCoroutine(PushJump());
        }
    }

    IEnumerator DelayJump()
    {
        yield return new WaitForSeconds(3);
        Jump();
        canJump = true;
    }

    IEnumerator TripleJump()
    {
        Jump();
        yield return new WaitForSeconds(1);
        Jump();
        yield return new WaitForSeconds(1);
        Jump();
        yield return new WaitForSeconds(1);
        canJump = true;
    }

    IEnumerator PushJump()
    {
        Jump();
        yield return new WaitForSeconds(1);
        canJump = true;
    }

    void Jump()
    {
        rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
}
