using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPool : MonoBehaviour {

	public GameObject[] specialPrefabs = new GameObject[3];

	public float spawnRate;

	private float timeSinceLastSpawned;

	void Start(){
		spawnRate = 5f; //first special item will be spawned after 5 unit of time.
		timeSinceLastSpawned = 0f;
	}

	void Update () {
		if (timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0f;
			spawnRate = Random.Range (2f, 5f);
			houseSpawn ();
		}
		timeSinceLastSpawned += Time.deltaTime;

		//Self-destroy
		if (PlayerControl.totalTime >= 60f) {
			Destroy (this.gameObject);
		}
	}

	public void houseSpawn(){
		int n = Random.Range (0, 3);
		Vector3 spawnPos = new Vector3 (this.transform.position.x, Random.Range (-3f, 3f), this.transform.position.y);
		GameObject h = Instantiate (specialPrefabs[n], spawnPos, this.transform.rotation) as GameObject;
		Destroy (h.gameObject, 5);
	}
}
