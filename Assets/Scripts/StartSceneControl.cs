using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneControl : MonoBehaviour {

    public Button playButton;
    public GameObject player;

    void Start()
    {
//        player.GetComponent<PlayerControl>().sheep = 0;

        Button Pbtn = playButton.GetComponent<Button>();
        Pbtn.onClick.AddListener(p);
    }

    void Update()
    {

    }

    void p()
    {
        SceneManager.LoadScene("inGame");
		PlayerControl.gameReset();
    }
}
