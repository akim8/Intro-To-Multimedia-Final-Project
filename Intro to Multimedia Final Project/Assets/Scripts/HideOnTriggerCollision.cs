using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnTriggerCollision : MonoBehaviour {

	// Attach to an object with a collider and Is Trigger checked.

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name == "Player Controller") {
			//Debug.Log("Player is touching object");
			this.gameObject.GetComponent<MeshRenderer> ().enabled = false;
		}
	}
	void OnTriggerExit(Collider col) {
		if (col.gameObject.name == "Player Controller") {
			//Debug.Log("Player is not touching object anymore");
			this.gameObject.GetComponent<MeshRenderer> ().enabled = true;
		}
	}
}
