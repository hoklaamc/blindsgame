using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botLedgeScript : MonoBehaviour {

	public GameObject blinds1;
	public GameObject blinds2;
	public GameObject blinds3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) 
		{
			blinds1.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds2.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds3.GetComponent<Rigidbody2D> ().gravityScale = -1;
		} 
		else if (Input.GetButtonUp("Fire1"))
		{
			blinds1.GetComponent<Rigidbody2D> ().gravityScale = 1;	
			blinds2.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds3.GetComponent<Rigidbody2D> ().gravityScale = 1;
		}		
	}
}
