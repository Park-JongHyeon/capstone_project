using UnityEngine;
using System.Collections;

public class ItemScale : MonoBehaviour {

	private Vector3 originalScale;
	private float modifier = 3.0f;
	private float timer = 0f;
	private bool inTransition = false;

	// Use this for initialization
	void Start () {
		originalScale = gameObject.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 1.0f && !inTransition) {
			inTransition = true;
			StartCoroutine (ScaleNow());
		}
	}

	private IEnumerator ScaleNow()
	{
		float scaleTimer = 0f;
		while (scaleTimer < 1.0f) {
			scaleTimer += Time.deltaTime;
			gameObject.transform.localScale = Vector3.Lerp (originalScale, originalScale * modifier, scaleTimer);
			yield return null;
		}
		inTransition = false;
		timer = 0f;
	}
}
