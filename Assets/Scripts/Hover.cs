using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{

    public float hoverPower = 300;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * hoverPower);
        }
    }
}