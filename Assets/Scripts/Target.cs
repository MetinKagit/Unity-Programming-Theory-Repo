using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float speed = 1;

    public float enemy_speed 
    {
        get { return speed; }
        set { speed = value; }
    }
    public virtual void MoveForward()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    
    public void DestroyAfterSeconds(float seconds)
    {
        Destroy(this.gameObject, seconds);
    }
}
