using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour {
	
	public GameObject menuCanvas;
	public GameObject blinds;

	void Start() 
	{
		//blinds.SetActive (false);
	}

	public void onStartGame()
	{
		//Debug.Log ("Start pressed!");
		menuCanvas.SetActive (false);
		//blinds.SetActive (true);
	}
}
