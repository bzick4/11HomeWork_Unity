using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallWalk : MonoBehaviour
{
    private Rigidbody ball;
    private Vector3 moveVector;
    private Animator animator;
    private float vert, horiz;
    [SerializeField] private float _rotationSpeed, _force;
    

    private void Start()
    {
        ball = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        WalkBall();
    }
    

    public void WalkBall()
    {
        Vector3 direct = new Vector3(vert, 0, -horiz);
        
        if (direct.magnitude > Math.Abs(0.1))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direct), Time.fixedDeltaTime * _rotationSpeed);
        }
        
        animator.SetFloat("Velocity", Vector3.ClampMagnitude(direct, 1).magnitude);
        ball.AddForce(Vector3.ClampMagnitude(direct, 1) * _force, ForceMode.Force);

    }

   
}
