using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallWalk : MonoBehaviour
{
    private Rigidbody ball;
    private Animator animator;
    private float vert, horiz;
    private Vector3 moveDirection;
    [SerializeField] private Transform cameraTransform;
    [SerializeField, Range(0,30)] private float _speed, _rotSpeed, _force;
    
    private void Start()
    {
        ball = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        vert = Input.GetAxis("Vertical");
        horiz = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Walk2();
    }
    
    public void Walk2()
    {
        moveDirection = new Vector3(horiz, 0, vert);
        moveDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * moveDirection;
        if (vert > 0.0f)
        {
            ball.AddForce(moveDirection * _speed);
        }
        else if (vert < 0f)
        {
            ball.AddForce(moveDirection * _speed);
        }
        else
        {
            moveDirection = Vector3.zero;
        }
        
        animator.SetFloat("Velocity", Vector3.ClampMagnitude(moveDirection, 1).magnitude);
    }
    
}
