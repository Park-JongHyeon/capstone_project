using UnityEngine;
using System.Collections;

public class RankingScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoveToMainScene()
	{
		Application.LoadLevel ("MainGameScene");
	}
}
