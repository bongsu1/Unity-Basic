using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UIControl : MonoBehaviour
{
    public UnityEvent OnPausing;
    public UnityEvent OnResume;

    void OnPause(InputValue value)
    {
        if(value.isPressed)
        {
            OnPausing?.Invoke();
        }
        else
        {
            OnResume?.Invoke();
        }
    }
}
