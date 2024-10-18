using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	public float scrollSpeed;

	void Update () {
		
		if (PlayerControl.totalTime <= 67f) {
			if (!PlayerControl.died) 
				this.transform.Translate (new Vector2 (scrollSpeed * Time.deltaTime, 0));
			
		}
	}
}
