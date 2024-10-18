using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMostCtrl : MonoBehaviour {


    float timer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 34f)
        {
            Application.LoadLevel("Menu");
        }
    }
}
