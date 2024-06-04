using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This is a parent class that will be inherited by the other target classes. */
public class Target : MonoBehaviour
{
    
    // ENCAPSULATION
    private float speed = 1; // private backing field

    // public property to access the private backing field
    public float enemy_speed 
    {
        get { return speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative target speed!");
            }
            else
            {
                speed = value;
            }
        }
    }
    
    // POLYMORPHISM
    // virtual method that can be overridden by child classes.
    public virtual void MoveForward() 
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    
    // ABSTRACTION
    public void Jump(float jumpForce)
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Apply an upward force
    }
    
    
    // method to destroy the target after a certain amount of time.
    public void DestroyAfterSeconds(float seconds)
    {
        StartCoroutine(ChangeColorAndDestroy(seconds));
    }

    IEnumerator ChangeColorAndDestroy(float seconds)
    {
        yield return new WaitForSeconds(seconds - 0.2f); // Wait for the specified amount of time minus 0.5 seconds

        Renderer renderer = GetComponent<Renderer>(); // Get the Renderer component
        renderer.material.color = Color.red; // Change the color to red

        yield return new WaitForSeconds(0.2f); // Wait for another 0.5 seconds

        Destroy(this.gameObject); // Destroy the target
    }
}
