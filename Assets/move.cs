using UnityEngine;
using System.Collections;


public class move : MonoBehaviour {
	private word word;
	private timer timer;
	private float h = 0.0f;
	private float v = 0.0f;
	private int item = 0;
	private Transform tr;
	public float moveSpeed = 1.0f;

	public float turnSpeed = 100.0f;

	private Animation anim;
	private bool isMoving = false;

//	private AudioSource source;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
		word = GameObject.Find ("word").GetComponent<word> ();
		timer = GameObject.Find ("timer").GetComponent<timer> ();
		tr = GetComponent<Transform> ();
		// start with idle animation
		anim.Play ("hop");
		//source.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		bool anyOfInputKeyPressed = false;

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
			anyOfInputKeyPressed = true;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			anyOfInputKeyPressed = true;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
			anyOfInputKeyPressed = true;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
			anyOfInputKeyPressed = true;
		}
		/*
		if (anyOfInputKeyPressed) {
			anim.Play ("hop");
		} else {
			anim.Play ("idle2");
		}*/

		#if UNITY_ANDROID
		if(Input.acceleration.z<0){
			//anim.Play("hop");
		transform.Translate(0, 0, -Input.acceleration.z*moveSpeed*Time.deltaTime);
		}else if(Input.acceleration.z>0){
		transform.Translate(0, 0, -Input.acceleration.z*8*Time.deltaTime);
			//anim.Play("hop");
		}
		transform.Rotate(0, Input.acceleration.x*turnSpeed*Time.deltaTime, 0);

		//float x = Input.acceleration.x;
		//float z = Input.acceleration.z;

		//Debug.Log(x);
		//transform.Translate(x, 0, 0);
		//transform.Translate(0, 0, -z * moveSpeed * Time.deltaTime);
		//transform.Rotate(0, 0, -x * turnSpeed);
		#endif
		/*h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");

		Debug.Log ("H = " + h.ToString ());
		Debug.Log ("V = " + v.ToString ());
		Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

		tr.Translate (moveDir * moveSpeed * Time.deltaTime, Space.Self);

		tr.Rotate (Vector3.up, rotate);
		//tr.Rotate (Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
	*/
	}

	void OnTriggerEnter (Collider coll){
	
		if (coll.tag == "Map") {
			//	tr.Translate (-Vector3.forward * moveSpeed * Time.deltaTime*3,Space.Self);
			tr.Translate (0, 0, Input.acceleration.z * moveSpeed * Time.deltaTime * 3);
		} else if (coll.gameObject.name.Equals("Pear") && item == 0) {
			SoundManager.soundManager.PlaySound ();
			Destroy(coll.gameObject);
			word.DispWord ("Pepper");
			item += 1;
		} else if(coll.gameObject.name.Equals("Pepper_Pointed") && item == 1){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Watermelon");
			item += 1;
		} else if(coll.gameObject.name.Equals("Watermelon") && item == 2){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Apple");
			item += 1;
		} else if(coll.gameObject.name.Equals("Apple_G") && item == 3){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Orange");
			item += 1;
		} else if(coll.gameObject.name.Equals("Orange") && item == 4){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Tomato");
			item += 1;
		} else if(coll.gameObject.name.Equals("Tomato") && item == 5){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();;
			word.DispWord ("Starwberry");
			item += 1;
		} else if(coll.gameObject.name.Equals("Strawberry") && item == 6){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Lemon");
			item += 1;
		} else if(coll.gameObject.name.Equals("Lemon") && item == 7){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Banana");
			item += 1;
		} else if(coll.gameObject.name.Equals("Banana") && item == 8){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			word.DispWord ("Coconut");
			item += 1;
		} else if(coll.gameObject.name.Equals("Coconut") && item == 9){
			Destroy(coll.gameObject);
			SoundManager.soundManager.PlaySound ();
			item += 1;
			timer.flag = 1;
		}
	}
		
}