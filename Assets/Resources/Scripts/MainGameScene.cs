using UnityEngine;
using System.Collections;

public class MainGameScene : MonoBehaviour {

	void Start () {
		// play background music
	}
	
	void Update () {
	
	}

	public void MoveToRabbitScene()
	{
		Application.LoadLevel ("RabbitScene");
	}

	public void MoveToArScene()
	{
		Application.LoadLevel ("ARScene");
	}
}
