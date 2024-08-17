using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMethod : MonoBehaviour
{
    [SerializeField] private Transform playerBall;
    [SerializeField] private Vector3 offset;
    

    private void Update()
    {
        CameraBall();
    }
    
    private void CameraBall()
    {
        transform.position = playerBall.position + offset;
    }
}
