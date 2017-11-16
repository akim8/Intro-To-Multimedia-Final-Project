using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardObject : MonoBehaviour {

	public bool matchX = false;
	public bool matchY = true;
	public bool matchZ = false;
	public GameObject facingObject;
	public float turnSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		// Set object to Player Controller if not set
		if (facingObject == null && GameObject.Find ("Player Controller") != null)
			facingObject = GameObject.Find ("Player Controller");
	}
	
	// Update is called once per frame
	void Update () {
		if (facingObject != null) {
			// Get target point for object to face
			var targetPoint = facingObject.transform.position - transform.position;
			// Set fixed axis
			if (matchX)
				targetPoint.x = 0;
			if (matchY)
				targetPoint.y = 0;
			if (matchZ)
				targetPoint.z = 0;
			// Set rotation
			Quaternion targetRotation = Quaternion.LookRotation (-targetPoint, Vector3.up);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * turnSpeed);
		}
	}
}
