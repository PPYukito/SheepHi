using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemControl : MonoBehaviour {

    public Text score;
    private int value;
	private PlayerControl p;

	public static bool shielded;
    public static bool bomz;

    public float timer;

	public int itemID; 

	public GameObject blink;

	/*
	0 = white sheep
	1 = black sheep
	2 = wolf sheep
	3 = balloon
	4 = gas
	5 = mini
	6 = bee
	7 = thorn
	8 = arrow
	9 = shield
	10 = bomb (good)
	*/

	void update()
	{
		
	}

	void blinkFX(GameObject spwnRef){
		GameObject e = Instantiate (blink, spwnRef.transform.position, 
			spwnRef.transform.rotation)as GameObject;
	}

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			PlayerControl o = other.GetComponent<PlayerControl> ();
			Destroy (this.gameObject);
			blinkFX (this.gameObject);
			switch (itemID) {
			case 0: //white
				PlayerControl.hp += 0.1f;
				PlayerControl.score += 1;
				o.dmgShow (0.1f);
				break;
			case 1: //black
				PlayerControl.hp += 0.1f;
				PlayerControl.score += 3;
				o.dmgShow (0.1f);
				break;
			case 2: //wolfSheep
				PlayerControl.hp += 0.3f;
				o.dmgShow (0.3f);
				break;
			case 3: //balloon
				PlayerControl.hp += 0.3f;
				o.dmgShow (0.3f);
				break;
			case 4: //gas
				PlayerControl.hp += 0.5f;
				o.dmgShow (0.5f);
				break;

			case 5://mini
				if (PlayerControl.ismini == false)
					PlayerControl.ismini = true; //***don't forget to change back
				break;

			case 6://bee
				if (!shielded || !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.1f;
					o.dmgShow (-0.1f);
				} else
					shielded = false;
				break;
			case 7://thorn
				if (!shielded && !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.2f;
					o.dmgShow (-0.2f);
				} else
					shielded = false;
				break;
			case 8://arrow
				if (!shielded && !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.4f;
					o.dmgShow (-0.4f);
				} else
					shielded = false;
				break;
			case 9://shield
				shielded = true;
				break;
			case 10://bomb
				if (bomz == false)
					bomz = true;
				break;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (this.gameObject);
			PlayerControl o = other.gameObject.GetComponent<PlayerControl> ();
			blinkFX (this.gameObject);
			switch (itemID) {
			case 0: //white
				PlayerControl.hp += 0.1f;
				PlayerControl.score += 1;
				o.dmgShow (0.1f);
				break;
			case 1: //black
				PlayerControl.hp += 0.1f;
				PlayerControl.score += 3;
				o.dmgShow (0.1f);
				break;
			case 2: //wolfSheep
				PlayerControl.hp += 0.3f;
				o.dmgShow (0.3f);
				break;
			case 3: //balloon
				PlayerControl.hp += 0.3f;
				o.dmgShow (0.3f);
				break;
			case 4: //gas
				PlayerControl.hp += 0.5f;
				o.dmgShow (0.5f);
				break;

			case 5://mini
				if (PlayerControl.ismini == false)
					PlayerControl.ismini = true; //***don't forget to change back
				break;

			case 6://bee
				if (!shielded && !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.1f;
					o.dmgShow (-0.1f);
				} else
					shielded = false;
				break;
			case 7://thorn
				if (!shielded && !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.2f;
					o.dmgShow (-0.2f);
				} else
					shielded = false;
				break;
			case 8://arrow
				if (!shielded && !PlayerControl.isHurting) {
					PlayerControl.isHurting = true;
					PlayerControl.hp -= 0.4f;
					o.dmgShow (-0.4f);
				} else
					shielded = false;
				break;
			case 9://shield
				shielded = true;
				break;
			case 10://bomb
				if (bomz == false)
					bomz = true;
				break;
			}
		}
	}


}