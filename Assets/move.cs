using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private word word;
	private float h = 0.0f;
	private float v = 0.0f;
	private int item = 0;
	private Transform tr;
	public float moveSpeed = 1.0f;

	public float turnSpeed = 50.0f;


	// Use this for initialization
	void Start () {
		word = GameObject.Find ("word").GetComponent<word> ();
		tr = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		
		#if UNITY_ANDROID
		transform.Translate(0, 0, -Input.acceleration.z*moveSpeed*Time.deltaTime);
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
			Destroy(coll.gameObject);
			word.DispWord ("Pepper");
			item += 1;
		} else if(coll.gameObject.name.Equals("Pepper_Pointed") && item == 1){
			Destroy(coll.gameObject);
			word.DispWord ("Watermelon");
			item += 1;
		} else if(coll.gameObject.name.Equals("Watermelon") && item == 2){
			Destroy(coll.gameObject);
			word.DispWord ("Apple");
			item += 1;
		} else if(coll.gameObject.name.Equals("Apple_G") && item == 3){
			Destroy(coll.gameObject);
			word.DispWord ("Orange");
			item += 1;
		} else if(coll.gameObject.name.Equals("Orange") && item == 4){
			Destroy(coll.gameObject);
			word.DispWord ("Tomato");
			item += 1;
		} else if(coll.gameObject.name.Equals("Tomato") && item == 5){
			Destroy(coll.gameObject);
			word.DispWord ("Starwberry");
			item += 1;
		} else if(coll.gameObject.name.Equals("Strawberry") && item == 6){
			Destroy(coll.gameObject);
			word.DispWord ("Lemon");
			item += 1;
		} else if(coll.gameObject.name.Equals("Lemon") && item == 7){
			Destroy(coll.gameObject);
			word.DispWord ("Banana");
			item += 1;
		} else if(coll.gameObject.name.Equals("Banana") && item == 8){
			Destroy(coll.gameObject);
			word.DispWord ("Coconut");
			item += 1;
		} else if(coll.gameObject.name.Equals("Coconut") && item == 9){
			Destroy(coll.gameObject);
			item += 1;
		}
	}
		
}