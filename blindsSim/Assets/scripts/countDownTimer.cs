using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countDownTimer : MonoBehaviour {
	public float initial_time;
    private float timeRemaining;
	public GameObject menuCanvas;

	public GUIStyle myStyle = new GUIStyle(); 

	// Use this for initialization
	void Start () {
		timeRemaining = 0;
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
			GUI.Label(new Rect(10, 10, 200, 100), "Time Remaining: " + (int)timeRemaining, myStyle);
        } else {
			GUI.Label(new Rect(10, 10, 200, 100), "Time's Up", myStyle);
			menuCanvas.SetActive (true);
        }        
    }

	public void resetTimer() {
		timeRemaining = initial_time;
	}
}
