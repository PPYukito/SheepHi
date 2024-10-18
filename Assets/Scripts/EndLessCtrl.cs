using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLessCtrl : MonoBehaviour {

    float timer = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > 18f)
        {
            Application.LoadLevel("Menu");
        }
    }
}
