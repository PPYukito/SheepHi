using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPool : MonoBehaviour {

	public GameObject[] sheepPrefabs = new GameObject[4];

	public float spawnRate;

	private float timeSinceLastSpawned;

	void Start(){
		spawnRate = 1f;
		timeSinceLastSpawned = 0f;
	}

	void Update () {
		if (timeSinceLastSpawned >= spawnRate) {
			timeSinceLastSpawned = 0f;
			spawnRate = Random.Range (0.5f, 3f);
			houseSpawn ();
		}
		timeSinceLastSpawned += Time.deltaTime;

		//Self-destroy
		if (PlayerControl.totalTime >= 60f) {
			Destroy (this.gameObject);
		}
	}

	public void houseSpawn(){
		int n = Random.Range (0, 8);
        if (n == 7)
        {
            n = 3;
        }
        else if (n == 6)
        {
            n = 2;
        }
        else if (n == 5)
        {
            n = 1;
        }
        else
        {
            n = 0;
        }
		GameObject h = Instantiate (sheepPrefabs[n], this.transform.position, this.transform.rotation) as GameObject;
		Destroy (h.gameObject, 5);
	}
}
