using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botLedgeScript : MonoBehaviour {

	public GameObject blinds1;
	public GameObject blinds2;
	public GameObject blinds3;
	public GameObject blinds4;
	public GameObject blinds5;
	public GameObject blinds6;
	public GameObject blinds7;
	public GameObject blinds8;
	public GameObject blinds9;
	public GameObject blinds10;
	public GameObject blinds11;
	public GameObject blinds12;
	public GameObject blinds13;
	public GameObject blinds14;
	public GameObject blinds15;
	public GameObject blinds16;
	public GameObject blinds17;
	public GameObject blinds18;

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
			blinds4.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds5.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds6.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds7.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds8.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds9.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds10.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds11.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds12.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds13.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds14.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds15.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds16.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds17.GetComponent<Rigidbody2D> ().gravityScale = -1;
			blinds18.GetComponent<Rigidbody2D> ().gravityScale = -1;
		} 
		else if (Input.GetButtonUp("Fire1"))
		{
			blinds1.GetComponent<Rigidbody2D> ().gravityScale = 1;	
			blinds2.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds3.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds4.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds5.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds6.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds7.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds8.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds9.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds10.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds11.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds12.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds13.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds14.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds15.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds16.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds17.GetComponent<Rigidbody2D> ().gravityScale = 1;
			blinds18.GetComponent<Rigidbody2D> ().gravityScale = 1;
		}		
	}
}
