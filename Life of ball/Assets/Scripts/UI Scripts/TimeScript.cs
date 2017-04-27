using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour {

    public string ellapsedTime; 
    DateTime time;
    float gameTime;
	// Use this for initialization
	void Start () {
        gameTime += time.Second;
        ellapsedTime = gameTime.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
