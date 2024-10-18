using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemControl : MonoBehaviour {

    public Text score;
    private int value;

	public static bool shielded;

	public float timer;

	public int itemID; 
	/*
	0 = white sheep
	1 = black sheep
	2 = wolf sheep
	3 = gas
	4 = thorn*
	5 = mini
	6 = bee
	7 = thorn
	8 = arrow
	9 = shield
	10 = bomb (good)
	*/

	void update()
	{
		timer += Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
			switch (itemID) {
			case 0: //white
				PlayerControl.hp += 0.1f;
				PlayerControl.score += 1;
				break;
			case 1: //black
				PlayerControl.hp += 0.2f;
				PlayerControl.score += 3;
				break;
			case 2: //wolfSheep
				PlayerControl.hp += 0.3f;
				break;
			case 3: //balloon
				PlayerControl.hp += 0.3f;
				break;
			case 4: //gas
				PlayerControl.hp += 0.5f;
				break;

			case 5://mini
				other.gameObject.transform.localScale /= 2; //***don't forget to change back
				break;
				
			case 6://bee
				if (!shielded)
					PlayerControl.hp -= 0.1f;
				else
					shielded = false;
				break;
			case 7://thorn
				if (!shielded)
					PlayerControl.hp -= 0.2f;
				else
					shielded = false;
				break;
			case 8://arrow
				if (!shielded)
					PlayerControl.hp -= 0.4f;
				else
					shielded = false;
				break;
			case 9://shield
				shielded = true;
                    break;
			case 10://bomb
                    //new BoxCollider2D = 
                    break;

			}
        }

    }
}