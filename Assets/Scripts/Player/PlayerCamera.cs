using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCamera : MonoBehaviour
{
    public CinemachineFreeLook freeLookCamera;  // Inspector에서 할당하세요
    public Transform player;

    void Update()
    {
        float cameraYRotation = freeLookCamera.m_XAxis.Value;
        player.rotation = Quaternion.Euler(0, cameraYRotation, 0);
    }
}

