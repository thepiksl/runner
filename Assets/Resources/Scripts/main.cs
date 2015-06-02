using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class main : MonoBehaviour {

	// floor
	Queue<GameObject> floor = new Queue<GameObject>();
	int floorCount = 10;
	float floorSize = 5;
	int pos = -5;

	// player
	GameObject player;
	Vector3 velocity = new Vector3(0.1f, 0, 0);

	void Start () {
		playerSetup();
		floorSetup();
	}

	void playerSetup() {
		player = Instantiate (Resources.Load ("Prefabs/player"),
		                      new Vector3(0, 0.4796f, 0),
		                      Quaternion.identity) as GameObject;
		//player.name = "player";
	}

	void floorSetup() {
		for (int i = 0; i < floorCount; i++) {
			pushFloor ();
		}
	}

	public void pushFloor() {
		floor.Enqueue (Instantiate (Resources.Load ("Prefabs/floor"),
		                            new Vector3((pos + 2) * floorSize, 0, 0),
		                            Quaternion.identity )as GameObject);
		pos++;
		if (floor.Count > floorCount) {
			Destroy(floor.Peek());
			floor.Dequeue();
			velocity.x += 0.003f;
		}
	}

	void Update () {
		player.transform.Translate(velocity);
	}
}
