using UnityEngine;
using System.Collections;

public class floorSensor : MonoBehaviour {

	main main;

	void Start () {
		main = GameObject.Find("_GM").GetComponent<main>();
		
	}
	
	void Update () {
	
	}

	void OnTriggerEnter(Collider c) {
		if (c.name == "player") {
			try {
				main.pushFloor(); // push floor
			} catch {

			}
		}
	}
}
