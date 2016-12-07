using UnityEngine;
using System.Collections;

public class Logout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public void MoveToLogout()
    {
        Entity.e.RemoveAt(0);
        Application.LoadLevel("LoginScene");
    }

}
