using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
    private static Manager2 instance;
    [SerializeField] GameManager2 gameManager;
    [SerializeField] DataManager2 dataManager;

    public static Manager2 Inst { get { return instance; } }
    public static GameManager2 Game { get { return instance.gameManager; } }
    public static DataManager2 Data {  get { return instance.dataManager; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }

    
}
