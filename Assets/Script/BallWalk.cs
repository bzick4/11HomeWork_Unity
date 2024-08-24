using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallWalk : MonoBehaviour
{
    private Rigidbody ball;
    private Vector3 direct;
    private Animator animator;
    private float vert, horiz;
    [SerializeField, Range(0,30)] private float _force;
    

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        direct = new Vector3(horiz,0,vert);
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        WalkBall2Ver();
    }
    
    public void WalkBall2Ver()
    {
        if (direct.magnitude > Math.Abs(0.1))
        {
            direct =((transform.right * vert) + (-horiz * transform.forward)).normalized;
            ball.MovePosition((transform.position + direct * _force * Time.fixedDeltaTime));
            
        }

        animator.SetFloat("Velocity", Vector3.ClampMagnitude(direct, 1).magnitude);
    }

   
    
    
}
