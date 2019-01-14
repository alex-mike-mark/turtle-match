using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour {

    private float timeToChangeDirection;
    private Rigidbody2D rb;
    Renderer rend;
    SpriteRenderer sr;
    bool flipped;

    private string flippedTag= "Flipped";

    // Use this for initialization
    public void Start()
    {
        ChangeDirection();
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<Renderer>();
        sr = gameObject.transform.Find("Symbol").GetComponent<SpriteRenderer>(); //hideous
        flipped = false;
        sr.enabled = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (!flipped)
        {
            timeToChangeDirection -= Time.deltaTime;

            if (timeToChangeDirection <= 0)
            {
                ChangeDirection();
            }

            rb.velocity = transform.up * 2;
        } else
        {
            rb.velocity = transform.up * 0;
        }
    }

    private void ChangeDirection()
    {
        float angle = Random.Range(0f, 360f);
        Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 newUp = quat * Vector3.up;
        newUp.z = 0;
        newUp.Normalize();
        transform.up = newUp;
        timeToChangeDirection = 1.5f;
    }

    public void toggleFlipped()
    {
        if (flipped == false)
        {
            flipped = true;
            rend.material.color = Color.white;
            sr.enabled = true;

            GameObject otherTurtle = GameObject.FindWithTag(flippedTag);
            if(otherTurtle != null){
                if( otherTurtle.transform.Find("Symbol").GetComponent<SpriteRenderer>().sprite == sr.sprite ){
                    Destroy(otherTurtle);
                    Destroy(gameObject);
                }
            } else {
                gameObject.tag = flippedTag;
            }
        }
        else
        {
            flipped = false;
            sr.enabled = false;
            rend.material.color = Color.green;
            gameObject.tag = "Untagged";
        }
    }
}
