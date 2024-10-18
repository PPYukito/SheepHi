using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour {

    public GameObject next;
    public GameObject play;
    public GameObject[] pages = new GameObject[4];
    private int i;
    public string name = "inGame";

    public AudioClip sound;
    public AudioSource source;

    // Use this for initialization
    void Start () {
        source.clip = sound;
        
        i = 0;
	}

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(sound);
            if (i == 3)
            {
                Destroy(next);
            }
            else if (i == 4)
            {
                Application.LoadLevel(name);
            }
            Destroy(pages[i]);
            i += 1;
        }

    }
}
