﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDownTimer : MonoBehaviour {

    public float timeRemaining;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
	}

    public int getTime() {
        return (int)timeRemaining;
    }

    private void OnGUI() {
        if (timeRemaining > 0) {
            GUI.Label(new Rect(100, 70, 200, 100), "Time Remaining: " + (int)timeRemaining);
        } else {
            GUI.Label(new Rect(100, 70, 200, 100), "Time's Up");
        }        
    }
}