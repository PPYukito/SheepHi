using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPool : MonoBehaviour {

	public GameObject balloonPrefab;

	public float spawnRate;

	private float timeSinceLastSpawned;

	void Start(){
		spawnRate = 2f;
		timeSinceLastSpawned = 0f;
	}

	void Update () {
		if (timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0f;
			spawnRate = Random.Range (1.5f, 3.5f);
			houseSpawn ();
		}
		timeSinceLastSpawned += Time.deltaTime;

		//Self-destroy
		if (PlayerControl.totalTime >= 60f) {
			Destroy (this.gameObject);
		}
	}

	public void houseSpawn(){
		Vector3 spawnPos = new Vector3 (this.transform.position.x, Random.Range (-6f, -1.5f), this.transform.position.z);
		GameObject h = Instantiate (balloonPrefab, spawnPos, this.transform.rotation) as GameObject;
	}
}
