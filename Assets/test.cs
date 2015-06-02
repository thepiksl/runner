using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public bool jump = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			jump = true;
		}
	}
}
