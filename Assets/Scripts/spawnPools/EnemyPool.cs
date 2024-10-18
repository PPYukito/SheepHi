using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour {

	public GameObject[] enemyPrefabs = new GameObject[2];

	public float spawnRate;
	private float arrowChance; //Var to increase rate of arrow spawning

	private float timeSinceLastSpawned;

	void Start(){
		spawnRate = 1.5f; //first special item will be spawned after 1.5 unit of time.
		timeSinceLastSpawned = 0f;

		arrowChance = 0;
	}

	void Update () {

		arrowChance = PlayerControl.totalTime / 10;

		if (timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0f;
			spawnRate = Random.Range (0.2f, 1.5f);
			houseSpawn ();
		}
		timeSinceLastSpawned += Time.deltaTime;

		//Self-destroy
		if (PlayerControl.totalTime >= 60f) {
			Destroy (this.gameObject);
		}



	}

	public void houseSpawn(){
		int n = Random.Range (0, 7);
		int limit;
		if (n <= arrowChance) {
			n = 1; //arrow
		} else {
			n = 0; //thorn
		}
		Vector3 spawnPos = new Vector3 (this.transform.position.x, Random.Range (-3f, 3f), this.transform.position.y);
		GameObject h = Instantiate (enemyPrefabs[n], spawnPos, this.transform.rotation) as GameObject;
		Destroy (h.gameObject, 5);
	}
}
