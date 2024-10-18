using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CongratControl : MonoBehaviour {

    public Text score;
    float time;

	// Use this for initialization
	void Start () {
        score.text = "" + PlayerControl.score;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time>= 5f)
        {
            if (PlayerControl.score <= 5)
            {
                Application.LoadLevel("EndingLess");
            }
            else if (PlayerControl.score <= 10)
            {
                Application.LoadLevel("EndingMore");
            }
            else
            {
                Application.LoadLevel("EndingMost");
            }
        }
	}

    public void gotoEnd()
    {

        
    }
}
