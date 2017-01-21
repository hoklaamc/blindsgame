using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blindsScript : MonoBehaviour {

    new AudioSource audio;

	// Use this for initialization
	void Start () {
        // Collision sound
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.magnitude > 3) {
            // Scales volume to velocity of collision
            audio.volume = collision.relativeVelocity.magnitude / 20;
            audio.Play();
        }
    }
}
