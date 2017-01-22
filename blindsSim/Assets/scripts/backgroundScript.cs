using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour {

	public GameObject background;
	private SpriteRenderer rend;

	void Start() {
		rend = background.GetComponent<SpriteRenderer>();
		rend.enabled = false;
	}

	public void hideBackground() {
		rend.enabled = false;
	}

	public void showBackground() {
		rend.enabled = true;
	}
}
