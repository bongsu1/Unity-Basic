using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessage : MonoBehaviour
{
    /************************************************************************
	 * ����Ƽ �޽��� �̺�Ʈ�Լ�
	 * 
	 * ����Ƽ�� ������ �޽����� �����ϴ� �Լ�
	 * MonoBehaviour Ŭ������ ���� �̸��� �Լ��� ������ ��� ����
	 * ��ũ��Ʈ�� ����Ƽ ������ ������ �޽����� �޾� ��� Ÿ�̹��� Ȯ��
	 * �޽��� �Լ����� �ڽ��� �ൿ�� �����Ͽ� ����� ����
	 ************************************************************************/

    private void Awake()
    {
        // ��ũ��Ʈ�� ���� ���ԵǾ��� �� 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ��

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        // (��ũ��Ʈ���� �ʱ�ȭ�۾�, �ܺ� ��Ȳ�� ������ �ʱ�ȭ �۾�)

        Debug.Log("Awake");
    }

	private void Start()
	{
        // ��ũ��Ʈ�� ���� ó������ Update �ϱ� ������ 1ȸ ȣ��
        // ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��� ȣ�� ���� ����

        // ���� : ��ũ��Ʈ�� �ʿ�� �ϴ� �ʱ�ȭ �۾� ����
        // (�ٸ� ��ũ��Ʈ���� ���� �ʱ�ȭ�۾�, �ܺ� ���ӻ�Ȳ�� �ʿ��� �ʱ�ȭ �۾�)
        
        Debug.Log("Start");
	}

    private void OnEnable()
    {
        // ��ũ��Ʈ�� Ȱ��ȭ �ɶ����� ȣ��

        // ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnEnable");
    }
    
    private void OnDisable()
    {
        // ��ũ��Ʈ�� ��Ȱ��ȭ �ɶ����� ȣ��

        // ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾� ����

        Debug.Log("OnDisable");
    }

    private void Update()
    {
        // ������ �����Ӹ��� ȣ��

        // ���� : �ٽ� ���� ���� ����

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // ���� ��� ���ӿ�����Ʈ�� Update�� ����� �� ȣ��

        // ���� : ������������ ���� ����� �ʿ��� ��ó�� ��� ����

        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        // ����Ƽ�� �������� �����ð����� ȣ�� (�⺻ 1�ʿ� 50��)
        // Update�� �ٸ��� �����Ӵ� ����� �����ð��� ����
        // ��, ���ӷ��� �� ������ ���� �۾��� FixedUpdate�� �������� �ʾƾ� ��

        // ���� : ������ ó��, ���ɰ� ������ ����� ������ ���� �ʾƾ� �ϴ� �۾�

        Debug.Log("FixedUpdate");
    }

    private void OnDestroy()
    {
        // ��ũ��Ʈ�� �����Ǿ��� ��� ȣ��

        // ���� : ��ũ��Ʈ�� ������ ����

        Debug.Log("OnDestroy");
    }
}