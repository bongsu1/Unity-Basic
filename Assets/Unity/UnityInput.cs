using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityInput : MonoBehaviour
{
    /******************************************************************************
	 * ����Ƽ �Է�
	 * 
	 * ����Ƽ���� ������� ����� ������ �� �ִ� ����
	 * ����ڴ� �ܺ� ��ġ�� �̿��Ͽ� ������ ������ �� ����
	 * ����Ƽ�� �پ��� Ÿ���� �Է±��(Ű���� �� ���콺, ���̽�ƽ, ��ġ��ũ�� ��)�� ����
	 ******************************************************************************/

    // <Device>
    // Ư���� ��ġ�� �������� �Է� ����
    // Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
    public void InputByDevice()
    {
        // Ű����
        if (Input.GetKeyDown(KeyCode.Space)) // ������ ��
        {
            Debug.Log("Space key is down");
        }
        if (Input.GetKey(KeyCode.Space))     // ������ �ִ� ��
        {
            Debug.Log("Space key is pressing");
        }
        if (Input.GetKeyUp(KeyCode.Space))   // ���� ��
        {
            Debug.Log("Space key is up");
        }

        // ���콺 �Է°���
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse left button is down");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse left button is pressing");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse left button is up");
        }
    }

    // <InputManager>
    // ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
    // �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
    // ����Ƽ �������� Edit -> Project Settings -> Input Manager ���� ����
    private void InputByInputManager()
    {
        // �� �Է�
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // ��ư �Է�
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 button is down");
        }
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Fire1 button is pressing");
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Debug.Log("Fire1 button is up");
        }
    }


    // <InputSystem>
    // InputSystem ��Ű���� �̿��� �Է¹��
    // ������Ʈ�� ���� �Է��� ��������� Ȯ��
    // �ֽſ� ������ ������� �پ��� ��⸦ ����
    Vector3 moveDir;
    private void OnMove(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x;
        moveDir.z = inputDir.y;
        Debug.Log(inputDir);
    }

    public Rigidbody rigid;
    private void OnJump(InputValue value)
    {
        //bool inputButton = value.isPressed;
        Jump();
        //Debug.Log(inputButton);
    }

    private void Jump()
    {
        rigid.AddForce(Vector3.up * 5f, ForceMode.Impulse);
    }

    private void Move()
    {
        transform.position += moveDir * 3f * Time.deltaTime;
    }

    private void Update()
    {
        Move();
    }
}
