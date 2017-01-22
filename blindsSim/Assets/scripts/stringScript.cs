using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stringScript : MonoBehaviour {

	public GameObject myLinkPrefab;
	public GameObject myLinkBase;
	public GameObject topLedge;
	public GameObject leftBar;
	public GameObject rightBar;
	public GameObject bottomBlind;
	List<GameObject> stringSet = new List<GameObject>();
	float stringOffsetX;
	float stringOffsetY;
	float stringOffsetZ;
	float prevBlindPositionY;
	int startingLinks;

	// Use this for initialization
	void Start () {
		startingLinks = 9;
		stringOffsetX = topLedge.transform.position.x + 1.7f;
		stringOffsetY = topLedge.transform.position.y - 0.35f;
		stringOffsetZ = -5f;
		print(stringOffsetX);
		print(stringOffsetY);
		// Initializes the set of string components.
		stringSet.Add(Instantiate(myLinkBase,
			new Vector3(stringOffsetX, stringOffsetY - (startingLinks - 1) * 0.55f - 0.5f, stringOffsetZ),
			new Quaternion(0, 0, 0, 0)));
		for (int i = 0; i  < startingLinks; i++) {
			stringSet.Add(Instantiate(myLinkPrefab,
				new Vector3(stringOffsetX, stringOffsetY - (startingLinks - i - 1) * 0.55f, stringOffsetZ),
				new Quaternion(0, 0, 0, 0)));
		}
		startingLinks += 2;
		//stringSet[0].GetComponentInParent<FixedJoint2D>().connectedBody =
		//stringSet[1].GetComponentInParent<Rigidbody2D>();
	}
	

	// Update is called once per frame
	void Update () {
		
		/*
		// Controls the string when the fire button is pressed.
		if (Input.GetKey(KeyCode.LeftControl)) { 
			if (stringSet[stringSet.Count - 1].transform.position.y <= stringOffsetY - 0.55f) {
				GameObject newLink = Instantiate(myLinkPrefab, new Vector3(stringOffsetX, stringOffsetY, 0),
					new Quaternion(0, 0, 0, 0));
				//stringSet[stringSet.Count - 1].GetComponentInParent<HingeJoint2D>().connectedBody =
				//newLink.GetComponentInParent<Rigidbody2D>();
				stringSet[stringSet.Count - 1].transform.Translate(0, -0.04f, 0);
				stringSet.Add(newLink);
			}
			foreach (GameObject go in stringSet) {
				go.transform.Translate(0, -0.04f, 0);
			}
		}
		// Controls the string when no action is being performed on the string.
		else if (stringSet.Count >= startingLinks || stringSet[stringSet.Count - 1].transform.position.y < stringOffsetY) {
			if (stringSet[stringSet.Count - 1].transform.position.y >= stringOffsetY) {
				GameObject temp = stringSet[stringSet.Count - 1];
				stringSet.Remove(temp);
				Destroy(temp);
			}
			foreach (GameObject go in stringSet) {
				go.transform.Translate(0, 0.04f, 0);
			}
		}
		*/
		
		//float yVelocity;
		float topPositionY = stringSet[stringSet.Count - 1].transform.position.y;
		float blindPositionY = bottomBlind.GetComponent<Rigidbody2D>().transform.position.y;
		float blindPositionYDiff = blindPositionY - prevBlindPositionY;
		prevBlindPositionY = blindPositionY;

		if (topPositionY <= stringOffsetY - 0.55f) {
			GameObject newLink = Instantiate(myLinkPrefab, new Vector3(stringOffsetX, topPositionY + 0.55f, stringOffsetZ),
				new Quaternion(0, 0, 0, 0));
			//stringSet[stringSet.Count - 1].GetComponentInParent<HingeJoint2D>().connectedBody =
			//newLink.GetComponentInParent<Rigidbody2D>();
			//stringSet[stringSet.Count - 1].transform.Translate(0, -0.04f, 0);
			stringSet.Add(newLink);
		}
		else if (topPositionY > stringOffsetY && stringSet.Count > 3) {
			stringSet.Remove(stringSet[stringSet.Count - 1]);
		}
		
		//yVelocity = (leftBar.GetComponent<Rigidbody2D>().velocity.y + rightBar.GetComponent<Rigidbody2D>().velocity.y) / 2;

		print(blindPositionYDiff);
		foreach (GameObject go in stringSet) {
			go.transform.Translate(0, -blindPositionYDiff, 0);
		}

		/*
		foreach (GameObject go in stringSet) {
			go.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, yVelocity, 0);
		}
		*/
	}
}
