using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoCtrl : MonoBehaviour {

    float timer = 0f;
    string nameNext = "Menu";
    
    void Start() {
        
    }

    void Update() {
        timer += Time.deltaTime;
        Debug.Log(timer);
		if (Input.GetKeyDown(KeyCode.Space) || timer >= 23f)
        {
            Application.LoadLevel(nameNext);
        }

    }

}
