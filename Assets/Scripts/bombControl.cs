using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombControl : MonoBehaviour {

    float timer;
	public GameObject blink;
    
    void Start () {
        timer = 0;
    }

	void Update () {
        timer += Time.deltaTime;	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (ItemControl.bomz)
        {
            Destroy(other.gameObject);
			blinkFX (other.gameObject);
            if (timer >= 2)
            {
                ItemControl.bomz = false;
            }

        }
    }

	void blinkFX(GameObject spwnRef){
		GameObject e = Instantiate (blink, spwnRef.transform.position, 
			spwnRef.transform.rotation)as GameObject;
	}


}
