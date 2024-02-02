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
        // <현재 게임오브젝트>
        // 컴포넌트가 붙어있는 게임오브젝트는 Component에 구현한 gameObject 속성을 이용하여 접근가능
        thisGameObject = gameObject;       // 컴포넌트가 붙어있는 게임오브젝트
        thisName = thisGameObject.name;    // 게임오브젝트의 이름
        thisActive = gameObject.activeSelf;// 게임오브젝트의 활성화 여부 (activeInHierachy : 게임씬에서 활성화 여부)
        thisTag = thisGameObject.tag;      // 게임오브젝트의 태그
        thisLayer = thisGameObject.layer;  // 게임오브젝트의 레이어
    }

    private void GameObjectFunction()
    {
        // <게임오브젝트 생성>
        newGameObject = new GameObject("NewGameObject");

        // <게임오브젝트 삭제>
        if (destroyGameObject != null)
        {
            Destroy(destroyGameObject, 3f);
        }

        // <게임오브젝트 탐색>
        findWithName = GameObject.Find("Main Camera");       // 이름으로 찾기
        findWithTag = GameObject.FindWithTag("Main Camera"); // 태그로 찾기

    }

    private void ComponentFunction()
    {
        // <컴포넌트 추가>
        addComponent = gameObject.AddComponent<Rigidbody>();
        // newComponent = new Rigidbody(); // 의미없음, 컴포넌트는 게임오브젝트에 부착되어 동작할때 의미있음

        // <컴포넌트 삭제>
        if (destroyComponent != null)
        {
            Destroy(destroyComponent);
        }

        // <컴포넌트 탐색 - 게임오브젝트에서 찾기>
        getComponent = gameObject.GetComponent<Collider>();

        // <컴포넌트 탐색 - 씬에서 찾기>
        findComponent = Component.FindObjectOfType<Camera>();
    }
}
