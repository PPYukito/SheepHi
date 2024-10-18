using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public float upforce = 600f;

	public static float totalTime = 0f; //Timer for ending game
	public static float endTime = 60f;

	public Text gravScaleT;
    public Text valueT;

    public GameObject distanceP;
    public GameObject gravScaleP;
	public GameObject barrier;
	public GameObject dmgSpawn;
	public GameObject[] dmgs = new GameObject[6];

	private float minitimer;
	private Vector3 minisize;

	private SpriteBlinking blinks;

    //Global variable
    public static bool died = false;
	public static float hp;
    public static int highscore = 0;
	public static int score = 0;

    public static float fuel = 0;
	public static bool isHurting = false;
	public static bool ismini = false;
    public static bool bomz = false;

    public AudioClip[] sound = new AudioClip[10];
    public AudioSource source;

    void Start()
    {
		hp = 3;
		score = 0;
		totalTime = 0f;
		Time.timeScale = 1;
		died = false;

        minisize = this.transform.localScale / 2.0f;
        minitimer = 0f;

		blinks = this.GetComponent<SpriteBlinking> ();
    }

	public static void gameReset(){
		hp = 3;
		score = 0;
		totalTime = 0f;
		Time.timeScale = 1;
		died = false;
	}

    void Update()
    {
		hp -= 0.1f*Time.deltaTime;
		totalTime += Time.deltaTime;
		//Debug.Log (totalTime);

		checkDead ();
		checkHighScore ();

		checkBarrier ();

		if (PlayerControl.totalTime >= 67f) {
			this.GetComponent<Rigidbody2D> ().gravityScale = 0;
			this.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
            if (PlayerControl.totalTime >= 69f)
            {
                Application.LoadLevel("Congrat");
            }

		} else {
			Jump();
			guage();

			//gravScaleT.text = "" + hp;
			//valueT.text = "" + score;
		}

		if (isHurting)
			Hurt();

		if (ismini) 
			downsize ();
		
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upforce);

        }
    }

    void guage()
    {
        distanceP.transform.Translate(0.1083f * Time.deltaTime, 0, 0);
        gravScaleP.transform.position = new Vector2((-8.45f + (0.75875f * hp)), gravScaleP.transform.position.y);

        if (gravScaleP.transform.position.x <= -8.45f + 0.05f)
		{
			gravScaleP.transform.position = new Vector2 (-8.45f + 0.05f, gravScaleP.transform.position.y);
		}

        if (gravScaleP.transform.position.x >= -8.45f + 6.12f)
        {
            gravScaleP.transform.position = new Vector2(-8.45f + 6.12f, gravScaleP.transform.position.y);
        }
    }

    void dead()
    {
        died = true;
        Application.LoadLevel("GameOver");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        

        if (other.gameObject.CompareTag("obstacle") && !isHurting)
        {
			hp -= 0.4f;
			dmgShow (-0.4f);
			isHurting = true;
            Hurt();
            
        }
        else
        {
            int i = other.gameObject.GetComponent<ItemControl>().itemID;
            source.PlayOneShot(sound[i]);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        int i = other.gameObject.GetComponent<ItemControl>().itemID;
		source.PlayOneShot(sound[i]);
        //Hurt();
    }

    public void Hurt(){
//		ItemControl.shielded = true;
		blinks.startBlinking = true;
        //start blinking effect
    }

    void downsize()
	{
        this.transform.localScale = minisize;
		 
		minitimer += 1*Time.deltaTime;

        if (minitimer > 2)
		{
            this.transform.localScale *= 2.0f;
			ismini = false;
            minitimer = 0;
        }
	}

	void checkDead(){
		if (this.transform.position.y > 6.2f || hp <= 0)
			dead();

	}

	void checkHighScore (){
		if (score > highscore)
			highscore = score;
	}

	void checkBarrier(){
		SpriteRenderer b = barrier.GetComponent<SpriteRenderer> ();
		if (ItemControl.shielded)
			b.enabled = true;
		else
			b.enabled = false;
	}

	public void dmgShow(float delta){
		int n = 0;

		if (delta == 0.1f)
			n = 0;
		else if (delta == 0.3f)
			n = 1;
		else if (delta == 0.5f)
			n = 2;
		else if (delta == -0.1f)
			n = 3;
		else if(delta == -0.2f)
			n = 4;
		else if(delta == -0.4f)
			n = 5;

		Vector2 dmgPos = new Vector2 (dmgSpawn.transform.position.x + 
			Random.Range (-0.4f, 0.4f), dmgSpawn.transform.position.y);
		GameObject d = Instantiate (dmgs [n], dmgPos, dmgSpawn.transform.rotation) as GameObject;
	}
}