using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseControl : MonoBehaviour {

    public bool paused;
	private Animator anim;

	// Use this for initialization
	void Start () {

        paused = false;
		anim = this.GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {



    }

	public void Pause()
	{
		
		paused = !paused;

		if (paused)
		{
			Time.timeScale = 0;
			anim.SetBool ("pause",true);

		}
		else if (!paused)
		{
			Time.timeScale = 1;
			anim.SetBool ("pause",false);
		}
	}

}
