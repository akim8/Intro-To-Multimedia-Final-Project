using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardCamera : MonoBehaviour {

	public bool matchX = false;
	public bool matchY = true;
	public bool matchZ = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Get current rotation
		float newX = transform.eulerAngles.x;
		float newY = transform.eulerAngles.y;
		float newZ = transform.eulerAngles.z;
		// Get camera rotation
		if (matchX)
			newX = Camera.main.transform.eulerAngles.x;
		if (matchY)
			newY = Camera.main.transform.eulerAngles.y;
		if (matchZ)
			newZ = Camera.main.transform.eulerAngles.z;
		// Set rotation
		transform.eulerAngles = new Vector3 (newX, newY, newZ);
	}
}
