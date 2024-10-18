using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSpawn : MonoBehaviour {

	public GameObject castle;

	void Start () {
		
	}

	void Update () {
		if (PlayerControl.totalTime >= 65f) {
			GameObject c = Instantiate (castle, this.transform.position, this.transform.rotation) as GameObject;
			Destroy (this.gameObject);
		}
	}
}
