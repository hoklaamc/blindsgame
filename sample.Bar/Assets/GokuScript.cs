using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GokuScript : MonoBehaviour {

	public GameObject platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			platform.GetComponent<Rigidbody2D> ().gravityScale = -1;
		} 
		else if (Input.GetButtonUp("Fire1"))
		{
			platform.GetComponent<Rigidbody2D> ().gravityScale = 1;	
		}
	}


}
