using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgLoopControl : MonoBehaviour {

	private Vector2 startPos;
	void Start () {
		startPos = this.transform.position;
	}

	void Update () {
		if(this.transform.position.x <= -startPos.x)
		{
			this.transform.position = startPos;
		}
	}
}
