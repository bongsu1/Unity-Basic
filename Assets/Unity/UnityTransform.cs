using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
    /************************************************************************************
	 * 트랜스폼 (Transform)
	 * 
	 * 게임오브젝트의 위치, 회전, 크기를 저장하는 컴포넌트
	 * 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
	 * 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
	 ************************************************************************************/

    public Transform thisTransform;

    // <트랜스폼 접근>
    private void TransformReferrence()
    {
        thisTransform = transform;
    }


    // <트랜스폼 이동>
    private void Translate()
    {
        // 월드를 기준으로 이동
        transform.Translate(1, 0, 0, Space.World);

        // 자신을 기준으로 이동
        transform.Translate(1, 0, 0, Space.Self);

        // position을 이용한 이동
        transform.position += new Vector3(1, 0, 0); // 월드 기준으로만 이동
    }


    // <트랜스폼 회전>
    private void Rotate()
    {
        // 월드를 기준으로 회전
        transform.Rotate(Vector3.up, 30, Space.World);

        // 자신을 기준으로 회전
        transform.Rotate(Vector3.up, 30, Space.Self);

        // 위치를 기준으로 회전
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);

        // 위치를 바라보는 회전
        transform.LookAt(new Vector3(0, 0, 0));
    }

    // <트랜스폼 축>
    private void Axis()
    {
        // 트랜스폼의 x축
        Vector3 right = transform.right;

        // 트랜스폼의 y축
        Vector3 up = transform.up;

        // 트랜스폼의 z축
        Vector3 forward = transform.forward;
    }


    // <트랜스폼 부모-자식 상태>
    // 트랜스폼은 부모 트랜스폼을 가질 수 있음
    // 부모 트랜스폼이 있는 경우 부모 트랜스폼의 위치, 회전, 크기 변경이 같이 적용됨
    // 이를 이용하여 계층적 구조를 정의하는데 유용함 (ex. 팔이 움직이면, 손가락도 같이 움직임)
    // 하이어라키 창 상에서 드래그 & 드롭을 통해 부모-자식 상태를 변경할 수 있음
    private void TransformParent()
    {
        GameObject newGameObject = new GameObject() { name = "NewGameObject" };

        // 부모 지정
        transform.parent = newGameObject.transform;

        // 부모를 기준으로한 트랜스폼
        // transform.localPosition	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 위치
        // transform.localRotation	: 부모트랜스폼이 있는 경우 부모를 기준으로 한 회전
        // transform.localScale		: 부모트랜스폼이 있는 경우 부모를 기준으로 한 크기

        // 부모 해제
        transform.parent = null;

        // 월드를 기준으로한 트랜스폼
        // transform.localPosition == transform.position	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 위치
        // transform.localRotation == transform.rotation	: 부모트랜스폼이 없는 경우 월드를 기준으로 한 회전
        // transform.localScale								: 부모트랜스폼이 없는 경우 월드를 기준으로 한 크기


    }


    // <Quarternion & Euler>
    // Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
    //				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
    // EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
    //				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
    // 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

    // Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
    // 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
    private void Rotation()
    {
        transform.rotation = Quaternion.identity;

        // 트랜스폼의 회전값은 Euler각도 표현이 아닌 Quaternion을 사용함
        Quaternion rotation = transform.rotation;

        /*Vector3 euler1 = rotation.eulerAngles;
        euler1 += new Vector3(10, 10, 10);
        transform.rotation = Quaternion.Euler(euler1);*/

        // Euler각도를 Quaternion으로 변환
        transform.rotation = Quaternion.Euler(0, 90, 0);

        // Quaternion각도를 Euler각도로 변환
        Vector3 euler = transform.rotation.eulerAngles;
    }
}