using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public void GamePause()
    {
        Time.timeScale = 0f;
    }
    
    public void GameResume()
    {
        Time.timeScale = 1f;
    }
}
