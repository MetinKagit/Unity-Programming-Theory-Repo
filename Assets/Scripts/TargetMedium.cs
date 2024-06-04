using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a child class. */
public class TargetMedium : Target // INHERITANCE
{
    void Start()
    {
        
        enemy_speed = 3f; //  Set the target speed
        Jump(5f);
        DestroyAfterSeconds(4f); // Destroy the target after a certain amount of time
    }

    void Update()
    {
        MoveForward(); // Call the MoveForward method in Update
    }

    
    // Override the MoveForward method
    public override void MoveForward()
    {
        base.MoveForward();
    }
}
