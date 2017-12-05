using UnityEngine;
using System.Collections;

public class HideUnlessNear : MonoBehaviour {
	public GameObject playerObject;
	public float distance = 15f;
	public bool playSound = true;
	public AudioClip soundClip;
	private AudioSource source;
	private bool alreadyPlayed = false;

	// Use this for initialization
	void Start () {
		if (playerObject == null && GameObject.Find ("Player Controller") != null)
			playerObject = GameObject.Find ("Player Controller");
		
		if (playSound) {
			if (soundClip != null)
				source = GetComponent<AudioSource> ();
			else
				Debug.Log ("No sound clip selected to play!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerObject != null) {
			var getDistance = Vector3.Distance (transform.position, playerObject.transform.position);
			if (getDistance < distance && GetComponentInChildren<Renderer> ().enabled == false) {
				GetComponentInChildren<Renderer> ().enabled = true;

				if (playSound) {
					if (soundClip != null && !alreadyPlayed) {
						source.PlayOneShot (soundClip);
						alreadyPlayed = true;
					}
				}
			}
			else if (getDistance >= distance && GetComponentInChildren<Renderer> ().enabled == true) {
				GetComponentInChildren<Renderer> ().enabled = false;
				alreadyPlayed = false;
			}
		}
	}
}

