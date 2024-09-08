
using UnityEngine;

 public class CameraMethod : MonoBehaviour
 {
     [SerializeField] private Transform playerBall;
     private Vector3 offset; 


     private void Start()
     {
        offset = transform.position - playerBall.position;
         
     }

     private void FixedUpdate()
     {
         CameraBall();
     }
     
     private void CameraBall()
     {
         transform.position = playerBall.position + offset;
     }
 }
 