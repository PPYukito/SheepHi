using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousePool : MonoBehaviour {

	public GameObject[] housePrefabs = new GameObject[14];
	public float spawnRate;
	private float timeSinceLastSpawned;

	void Start(){
		spawnRate = 3f;
		timeSinceLastSpawned = 0f;
	}

	void Update () {
			if (timeSinceLastSpawned >= spawnRate) {
				timeSinceLastSpawned = 0f;
				spawnRate = Random.Range (2f, 6f);
				houseSpawn ();
			}
			timeSinceLastSpawned += Time.deltaTime;

		//Self-destroy
		if (PlayerControl.totalTime >= 60f) {
			Destroy (this.gameObject);
		}
	}

	public void houseSpawn(){
		int n = Random.Range (0, 13);
		GameObject h = Instantiate (housePrefabs[n], this.transform.position, this.transform.rotation) as GameObject;
		Destroy (h.gameObject, 6);
	}

}
