using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMoreCtrl : MonoBehaviour {

    float timer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 12f)
        {
            Application.LoadLevel("Menu");
        }
    }
}
