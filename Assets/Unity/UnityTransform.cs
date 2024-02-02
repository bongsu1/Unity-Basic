using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
    /************************************************************************************
	 * Ʈ������ (Transform)
	 * 
	 * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
	 ************************************************************************************/

    public Transform thisTransform;

    // <Ʈ������ ����>
    private void TransformReferrence()
    {
        thisTransform = transform;
    }


    // <Ʈ������ �̵�>
    private void Translate()
    {
        // ���带 �������� �̵�
        transform.Translate(1, 0, 0, Space.World);

        // �ڽ��� �������� �̵�
        transform.Translate(1, 0, 0, Space.Self);

        // position�� �̿��� �̵�
        transform.position += new Vector3(1, 0, 0); // ���� �������θ� �̵�
    }


    // <Ʈ������ ȸ��>
    private void Rotate()
    {
        // ���带 �������� ȸ��
        transform.Rotate(Vector3.up, 30, Space.World);

        // �ڽ��� �������� ȸ��
        transform.Rotate(Vector3.up, 30, Space.Self);

        // ��ġ�� �������� ȸ��
        transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, 30);

        // ��ġ�� �ٶ󺸴� ȸ��
        transform.LookAt(new Vector3(0, 0, 0));
    }

    // <Ʈ������ ��>
    private void Axis()
    {
        // Ʈ�������� x��
        Vector3 right = transform.right;

        // Ʈ�������� y��
        Vector3 up = transform.up;

        // Ʈ�������� z��
        Vector3 forward = transform.forward;
    }


    // <Ʈ������ �θ�-�ڽ� ����>
    // Ʈ�������� �θ� Ʈ�������� ���� �� ����
    // �θ� Ʈ�������� �ִ� ��� �θ� Ʈ�������� ��ġ, ȸ��, ũ�� ������ ���� �����
    // �̸� �̿��Ͽ� ������ ������ �����ϴµ� ������ (ex. ���� �����̸�, �հ����� ���� ������)
    // ���̾��Ű â �󿡼� �巡�� & ����� ���� �θ�-�ڽ� ���¸� ������ �� ����
    private void TransformParent()
    {
        GameObject newGameObject = new GameObject() { name = "NewGameObject" };

        // �θ� ����
        transform.parent = newGameObject.transform;

        // �θ� ���������� Ʈ������
        // transform.localPosition	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ��ġ
        // transform.localRotation	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ȸ��
        // transform.localScale		: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ũ��

        // �θ� ����
        transform.parent = null;

        // ���带 ���������� Ʈ������
        // transform.localPosition == transform.position	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ��ġ
        // transform.localRotation == transform.rotation	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ȸ��
        // transform.localScale								: �θ�Ʈ�������� ���� ��� ���带 �������� �� ũ��


    }


    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    private void Rotation()
    {
        transform.rotation = Quaternion.identity;

        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        Quaternion rotation = transform.rotation;

        /*Vector3 euler1 = rotation.eulerAngles;
        euler1 += new Vector3(10, 10, 10);
        transform.rotation = Quaternion.Euler(euler1);*/

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);

        // Quaternion������ Euler������ ��ȯ
        Vector3 euler = transform.rotation.eulerAngles;
    }
}