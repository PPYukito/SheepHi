using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public AudioSource audio;

    // Use this for initialization
    void Start () {
        audio.volume = 1f;
	}

    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.died)
        {
            audio.volume = 0.35f;
        }
        else
        {
            audio.volume = 1f;
        }
    }
}
