using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRArm : MonoBehaviour {

    public float movementSpeed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * movementSpeed);
            rb.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.down * movementSpeed);
            rb.velocity = Vector3.zero;
        }
    }

}
