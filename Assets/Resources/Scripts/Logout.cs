﻿using UnityEngine;
using System.Collections;

public class Logout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void MoveToLogout()
    {
        Application.LoadLevel("LoginScene");
    }

}
