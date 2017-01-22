using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScript : MonoBehaviour {

	public GameObject background;

	public void hideBackground() {
		background.SetActive (false);
	}

	public void showBackground() {
		background.SetActive (true);
	}
}
