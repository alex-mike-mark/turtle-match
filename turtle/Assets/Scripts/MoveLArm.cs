using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLArm : MonoBehaviour {

    float movementSpeed = 40.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
         {
             transform.position += Vector3.left * movementSpeed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.D))
         {
             transform.position += Vector3.right * movementSpeed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.W))
         {
             transform.position += Vector3.up * movementSpeed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.S))
         {
             transform.position += Vector3.down * movementSpeed * Time.deltaTime;
         }
    }
}
