using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	void OnCollisionEnter(Collision coll){

		//if (coll.collider.tag == "MAP") {
		Destroy (coll.gameObject);
		//}
	}
}
