using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCtrl : MonoBehaviour {

	public void loadScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

}
