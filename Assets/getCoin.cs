using UnityEngine;
using System.Collections;

public class getCoin : MonoBehaviour {

	private coin coin;

	void Start(){
		coin = GameObject.Find ("coin").GetComponent<coin> ();
	}

	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * 100.0f, Color.green);
		RaycastHit hit;

		#if UNITY_ANDROID

		if(Input.touchCount> 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			coin.DispCoin(1);
			ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

			if (Physics.Raycast(ray, out hit, 100.0f))
			{
				if(hit.collider.tag == "AR"){
					
				}
			}

		}
		#endif

	}
}
