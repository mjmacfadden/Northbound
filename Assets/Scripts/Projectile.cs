using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // this global variable will be set from the inspector. Represents pipe velocity
    public Vector2 foregroundVelocity = new Vector2();
    public float destroyPosition = -11;

    // function to be executed once the pipe is created
    void Start()
    {
        // setting the velocity of the rigid body component attached to the pipe
        GetComponent<Rigidbody2D>().linearVelocity = foregroundVelocity;
    }


    // function to be executed at each frame
    void Update()
    {
        // checking x position
        if (transform.position.x < destroyPosition)
        {
            // destroying the pipe and freeing memory and resources
            Destroy(gameObject);
        }
    }
}