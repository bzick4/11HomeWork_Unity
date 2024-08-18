using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

 public class CameraMethod : MonoBehaviour
 {
     [SerializeField] private Transform playerBall;
     [SerializeField] private Vector3 offset;
     public float smooth = 5f;
     

     private void LateUpdate()
     {
         CameraBall();
     }
     
     private void CameraBall()
     {
         Vector3 desire = playerBall.position + offset;
         //transform.position = playerBall.position + offset; 
         Vector3 smoothPos = Vector3.Lerp(transform.position, desire, smooth * Time.deltaTime);
         transform.position = smoothPos;
         transform.LookAt(playerBall);
     }
 }
 