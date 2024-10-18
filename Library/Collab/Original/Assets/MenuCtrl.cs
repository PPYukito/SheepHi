using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCtrl : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}
