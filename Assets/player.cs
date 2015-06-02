using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	Vector3 znizaj = new Vector3(1f, 0.5f, 1f);
	Vector3 zvisaj = new Vector3(1f, 1.5f, 1f);

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.transform.localScale = znizaj;
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			this.transform.localScale = zvisaj;
		}
	}
}
