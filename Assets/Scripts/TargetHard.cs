using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a child class. */
public class TargetHard : Target // INHERITANCE
{
    public float rotationSpeed = 100f; // Rotation speed
    private Rigidbody rb;
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
        Jump(5f);
        enemy_speed = 5f; // Set the target speed
        DestroyAfterSeconds(5.5f); // Destroy the target after a certain amount of time
    }

    void Update()
    {
        MoveForward(); 
    }

    // Override the MoveForward method
    public override void MoveForward() // POLYMORPHISM
    {
        rb.AddTorque(Vector3.left * rotationSpeed);
    }
    
}
