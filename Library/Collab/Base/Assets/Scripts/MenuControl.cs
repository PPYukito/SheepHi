using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour {

    public AudioSource audio;

    void Start() {
        audio.Play();
    }

    void Update() {
        
    }

	public void inGame()
	{
		string name1 = "inGame";
		Application.LoadLevel (name1);
	}

	public void tutorial()
	{
		string name2 = "How to";
		Application.LoadLevel (name2);
	}
}
