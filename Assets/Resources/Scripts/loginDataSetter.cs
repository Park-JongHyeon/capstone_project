using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loginDataSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Text mylogin = GameObject.Find("logText").GetComponent<Text>();
        Entity.e.Add(new _e {_s = mylogin.text });
	}
    	
}
