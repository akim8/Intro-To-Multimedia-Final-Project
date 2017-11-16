using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Quit game
		if (Input.GetKey ("escape")) {
			Application.Quit ();
			//UnityEditor.EditorApplication.isPlaying = false;
		}
	}
}
