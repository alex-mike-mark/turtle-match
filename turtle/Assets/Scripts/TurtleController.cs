using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    private float moveChance = 0.03f;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        // probably a random rotation or something
    }

    // Update is called once per frame
    // Decide if the turtle is going to start moving
    // 
    void Update()
    {
        // do we decide to move?
        if ( !moving && Random.Range(0.0f,1.0f) < moveChance ){
            moving = true;
            // rotate
            // start anim
        }
        
        // if end anim
            // actually move turtle
            // start "reverse" anim
            
    }
}
