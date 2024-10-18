using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public string name = "GameOver";
    public AudioSource audio;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerControl.died)
		{
            Application.LoadLevel(name);
            audio.volume = 0.35f;
        }
	}
}
