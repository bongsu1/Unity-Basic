using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityFunction : MonoBehaviour
{
    [Header("This")]
    public GameObject thisGameObject;
    public string thisName;
    public bool thisActive;
    public string thisTag;
    public int thisLayer;

    [Header("GameObject")]
    public GameObject newGameObject;
    public GameObject destroyGameObject;
    public GameObject findWithName;
    public GameObject findWithTag;

    [Header("Component")]
    public Component addComponent;
    public Component destroyComponent;
    public Component getComponent;
    public Component findComponent;

    private void Start()
    {
        // ThisFunction();
        // GameObjectFunction();
        ComponentFunction();
    }

    private void ThisFunction()
    {
        // <���� ���ӿ�����Ʈ>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� Component�� ������ gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        thisGameObject = gameObject;       // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        thisName = thisGameObject.name;    // ���ӿ�����Ʈ�� �̸�
        thisActive = gameObject.activeSelf;// ���ӿ�����Ʈ�� Ȱ��ȭ ���� (activeInHierachy : ���Ӿ����� Ȱ��ȭ ����)
        thisTag = thisGameObject.tag;      // ���ӿ�����Ʈ�� �±�
        thisLayer = thisGameObject.layer;  // ���ӿ�����Ʈ�� ���̾�
    }

    private void GameObjectFunction()
    {
        // <���ӿ�����Ʈ ����>
        newGameObject = new GameObject("NewGameObject");

        // <���ӿ�����Ʈ ����>
        if (destroyGameObject != null)
        {
            Destroy(destroyGameObject, 3f);
        }

        // <���ӿ�����Ʈ Ž��>
        findWithName = GameObject.Find("Main Camera");       // �̸����� ã��
        findWithTag = GameObject.FindWithTag("Main Camera"); // �±׷� ã��

    }

    private void ComponentFunction()
    {
        // <������Ʈ �߰�>
        addComponent = gameObject.AddComponent<Rigidbody>();
        // newComponent = new Rigidbody(); // �ǹ̾���, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Ҷ� �ǹ�����

        // <������Ʈ ����>
        if (destroyComponent != null)
        {
            Destroy(destroyComponent);
        }

        // <������Ʈ Ž�� - ���ӿ�����Ʈ���� ã��>
        getComponent = gameObject.GetComponent<Collider>();

        // <������Ʈ Ž�� - ������ ã��>
        findComponent = Component.FindObjectOfType<Camera>();
    }
}
