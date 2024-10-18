using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgControl : MonoBehaviour {

	private SpriteRenderer s;
	private float opa;

	void Start () {
		this.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 350);
		s = this.GetComponent<SpriteRenderer> ();
		opa = 1f;
		Destroy (this.gameObject, 1.5f);
	}

	void Update () {
		opa = Mathf.Lerp (opa, 0f, Time.deltaTime*2);
		s.color = new Color (1f, 1f, 1f, opa);
	}
}
