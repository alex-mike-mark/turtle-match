using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject turtle;
	// Use this for initialization
	void Start () {
        
        ReleaseTheTurtles();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ReleaseTheTurtles()
    {
        int spawnPointX;
        int spawnPointY;
        Vector3 spawnPosition;

        for (int i = 0; i < 10; i++)
        {
            spawnPointX = Random.Range(-30, 1);
            spawnPointY = Random.Range(-1, 3);
            spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);

            Instantiate(turtle, spawnPosition, Quaternion.identity);
        }
    }
}
