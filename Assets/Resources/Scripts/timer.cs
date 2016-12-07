using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text txtTime;
	public static float time;
	public int flag =0;
    Text timeValue = GameObject.Find("timeValue").GetComponent<Text>();

    // Use this for initialization
    void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0) {
			time += Time.deltaTime;
		}
		int t = Mathf.FloorToInt (time);
		txtTime.text= "Time : " + t.ToString ();
        timeValue.text = t.ToString();
    }
}
