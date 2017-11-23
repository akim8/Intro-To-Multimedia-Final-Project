using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string nextSceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		// https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
		//Debug.Log ((nextSceneName != "")); // Is variable empty?
		//Debug.Log(Application.CanStreamedLevelBeLoaded (nextSceneName)); // Does scene exist?
		if (col.gameObject.name == "Player Controller" && nextSceneName != "" && Application.CanStreamedLevelBeLoaded (nextSceneName)) {
			SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
		}
	}
}
