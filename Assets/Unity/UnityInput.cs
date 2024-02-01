using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UnityInput : MonoBehaviour
{
    /******************************************************************************
	 * 유니티 입력
	 * 
	 * 유니티에서 사용자의 명령을 감지할 수 있는 수단
	 * 사용자는 외부 장치를 이용하여 게임을 제어할 수 있음
	 * 유니티는 다양한 타입의 입력기기(키보드 및 마우스, 조이스틱, 터치스크린 등)를 지원
	 ******************************************************************************/

    // <Device>
    // 특정한 장치를 기준으로 입력 감지
    // 특정한 장치의 입력을 감지하기 때문에 여러 플랫폼에 대응이 어려움
    public void InputByDevice()
    {
        // 키보드
        if (Input.GetKeyDown(KeyCode.Space)) // 눌렀을 때
        {
            Debug.Log("Space key is down");
        }
        if (Input.GetKey(KeyCode.Space))     // 누르고 있는 중
        {
            Debug.Log("Space key is pressing");
        }
        if (Input.GetKeyUp(KeyCode.Space))   // 땟을 때
        {
            Debug.Log("Space key is up");
        }

        // 마우스 입력감지
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
    // 여러 장치의 입력을 입력매니저에 이름과 입력을 정의
    // 입력매니저의 이름으로 정의한 입력의 변경사항을 확인
    // 유니티 에디터의 Edit -> Project Settings -> Input Manager 에서 관리
    private void InputByInputManager()
    {
        // 축 입력
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // 버튼 입력
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
    // InputSystem 패키지를 이용한 입력방식
    // 컴포넌트를 통해 입력의 변경사항을 확인
    // 최신에 지원한 방식으로 다양한 기기를 지원
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
