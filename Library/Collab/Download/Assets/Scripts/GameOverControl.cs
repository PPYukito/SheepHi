using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverControl : MonoBehaviour {

    public Text score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score.text = "" + PlayerControl.score;
        
    }

    public void gotoStart()
    {
        string name1 = "Menu";
        Application.LoadLevel(name1);
    }

    public void playAgain()
    {
        string name2 = "inGame";
        Application.LoadLevel(name2);


    }
}
