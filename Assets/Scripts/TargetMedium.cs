using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMedium : Target
{
    void Start()
    {
        enemy_speed = 5f; // Set the speed for medium enemy
        DestroyAfterSeconds(5f); // Destroy the enemy after 5 seconds
    }

    void Update()
    {
        MoveForward(); // Call the MoveForward method in Update
    }

    public override void MoveForward()
    {
        base.MoveForward();
    }
}
