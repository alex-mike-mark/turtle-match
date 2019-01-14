using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleSensor : MonoBehaviour {
    bool triggered;
    

    // Use this for initialization
    void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (triggered == false && (collision.name == "RArm" || collision.name == "LArm"))
        {
            //Debug.Log("Hand touching turtle!!");
            if (Input.GetKey(KeyCode.Space))
            {
                GetComponent<TurtleController>().toggleFlipped();
                triggered = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
