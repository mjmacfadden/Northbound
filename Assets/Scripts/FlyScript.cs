using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public float FallingFlyPower = 300f;
    public float HoveringFlyPower = 300f;
    public float RisingFlyPower = 300f;
    public bool flapping = false;
    private Animator animator;
    private Rigidbody2D rb;

    void Awake()
    {
        animator = GetComponent<Animator>(); //this assigns the gameObjects Animator to the variable animator
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Flap", true);
            flapping = true;
            if (rb.linearVelocity.y < 0)
            {
                rb.AddForce(Vector2.up * FallingFlyPower);
                //print("Falling");
            }
            else if (rb.linearVelocity.y == 0f)
            {
                rb.AddForce(Vector2.up * HoveringFlyPower);
                //print("Hovering");
            }
            else
            {
                rb.AddForce(Vector2.up * RisingFlyPower);
                //print("Rising");
            }
        }
        if (Input.GetButtonUp("Fire1") || Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("Flap", false);
            flapping = false;
        }
    }
}
