using UnityEngine;
using System.Collections;

public class FishScript : MonoBehaviour {

	bool isGrabbed = false;
	bool isFlying = false;
	public float launchFactor;

	public Transform launchPoint;

	// Use this for initialization
	void Start () {
		//launchPoint = GameObject.Find ("LaunchPoint").transform;
		ResetPosition();
	}

	private void ResetPosition(){
		transform.position = launchPoint.position;
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		isGrabbed = false;
		isFlying = false;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			this.isGrabbed = false;
			this.isFlying = false;
			this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			ResetPosition();
		}		
	}

	void FixedUpdate(){

		if(isGrabbed){
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			worldPosition.z = 0;
			//Debug.Log ("World Position: " + worldPosition.ToString());
			this.transform.position = worldPosition;
		}

		if(!isFlying){
			this.GetComponent<Rigidbody2D>().gravityScale = 0;
		} else {
			this.GetComponent<Rigidbody2D>().gravityScale = 1;

			//Bonus: Camera follows flying fish
			//Vector3 cameraPos = Camera.main.transform.position;
			//Vector3 fishPos = this.transform.position;
			//Camera.main.transform.position = Camera.main.WorldToScreenPoint(fishPos);
		}

	}

	void OnMouseDown(){
		Debug.Log ("FishScript.OnMouseDown()");
		isGrabbed = true;
	}

	void OnMouseUp(){
		if(isGrabbed){
			isGrabbed = false;
			isFlying = true;

			Vector3 diff = launchPoint.transform.position - this.transform.position;

			this.GetComponent<Rigidbody2D>().velocity = diff * launchFactor;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.name == "Ganon"){
			GameObject.Destroy(coll.gameObject);

			ResetPosition();

		}

		if(coll.gameObject.name == "Ganon"){
			Vector3 cameraPosition = GameObject.Find("Main Camera").transform.position;
			cameraPosition.z = 0;
			Debug.Log (cameraPosition.ToString());
		}
	}
}
