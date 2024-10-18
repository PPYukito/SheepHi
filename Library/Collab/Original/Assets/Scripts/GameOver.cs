using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject gameOver;
    public GameObject back;
    public GameObject replay;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerControl.died)
		{
            Time.timeScale = 0;
            Vector2 spawn = new Vector2(0,0);
            Vector2 spawnB = new Vector2((-2.5f),(-2));
            Vector2 spawnR = new Vector2((2.5f), (-2));
            GameObject GO = Instantiate(gameOver, spawn, this.transform.rotation) as GameObject;
            GameObject Back = Instantiate(back, spawnB, this.transform.rotation) as GameObject;
            GameObject Replay = Instantiate(replay, spawnR, this.transform.rotation) as GameObject;
            PlayerControl.died = false;
        }
	}
}
