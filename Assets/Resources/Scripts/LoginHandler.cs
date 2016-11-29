using UnityEngine;
using System.Collections;

public class LoginHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveToGameScene()
	{
		Application.LoadLevel ("MainGameScene");
	}
}
