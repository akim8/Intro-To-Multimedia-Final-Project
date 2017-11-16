using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCup : MonoBehaviour {

	public GameObject playerObject;

	// Use this for initialization
	void Start () {
		if (playerObject == null && GameObject.Find ("Player Controller") != null)
			playerObject = GameObject.Find ("Player Controller");
	}
	
	// Update is called once per frame
	void Update () {
		if (playerObject != null) {
			GameObject lidClosed = GameObject.Find ("Lid_closed");
			GameObject lidOpen = GameObject.Find ("Lid_open");
			var distance = Vector3.Distance (transform.position, playerObject.transform.position);
			//Debug.Log ("Distance between garlic cup and player: " + distance);
			if (distance < 3 && lidClosed.GetComponentInChildren<Renderer> ().enabled == true) {
				lidClosed.GetComponentInChildren<Renderer> ().enabled = false;
				lidOpen.GetComponentInChildren<Renderer> ().enabled = true;
			}
			else if (distance >= 3 && lidOpen.GetComponentInChildren<Renderer> ().enabled == true) {
				lidOpen.GetComponentInChildren<Renderer> ().enabled = false;
				lidClosed.GetComponentInChildren<Renderer> ().enabled = true;
			}
		}
	}
}
