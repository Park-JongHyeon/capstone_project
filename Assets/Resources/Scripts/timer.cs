﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text txtTime;
	public static float time;
	public int flag =0;

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
        Text timeValue = GameObject.Find("timeValue").GetComponent<Text>();
        txtTime.text= "Time : " + t.ToString ();
        timeValue.text = txtTime.text;
        Debug.Log(timeValue.text);
    }

}
