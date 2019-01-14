﻿using System.Collections;
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

                Vector3 oldPosition = gameObject.transform.position;
        Vector3 newPosition = oldPosition;

        //it's Min of right,  top bounds
        //it's a Max of left, bottom bounds.
        newPosition.x = Mathf.Min(oldPosition.x,33);
        newPosition.x = Mathf.Max(newPosition.x,-33);
        newPosition.y = Mathf.Min(oldPosition.y,17);
        newPosition.y = Mathf.Max(newPosition.y,-14);

        gameObject.transform.position = newPosition;
    }

}
