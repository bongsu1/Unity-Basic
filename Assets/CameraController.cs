using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //public Transform follow;

    //public Vector3 offset;

    public CinemachineVirtualCamera nomalCamera;
    public CinemachineVirtualCamera zoomCamera;

    //private void LateUpdate()
    //{
    //    transform.position = follow.position + offset;
    //    transform.LookAt(follow.position);
    //}

    void OnZoom(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Zoom on");
            zoomCamera.Priority = 50;
        }
        else
        {
            Debug.Log("Zoom off");
            zoomCamera.Priority = 1;
        }
    }
}
