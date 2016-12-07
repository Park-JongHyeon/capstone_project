using UnityEngine;
using System.Collections;

public class MainGameScene : MonoBehaviour {

	void Start () {
		// play background music
	}
	
	void Update () {
	
	}


	public void MoveToARScene()
	{
		Application.LoadLevel ("ARScene");
	}


	public void MoveToRabbitScene()
	{
		Application.LoadLevel ("RabbitScene");
	}


	public void MoveToMainScene()
	{
		Application.LoadLevel ("MainGameScene");
	}
	public void MoveToArScene()
	{
		Application.LoadLevel ("ARScene");

	}
    public void MoveToRegisterScene()
    {
        Application.LoadLevel("RegisterScene");

    }

	public void MoveToRankingScene()
	{
		Application.LoadLevel("RankingScene");

	}

	public void MoveToLoginScene()
	{
		Application.LoadLevel("LoginScene");

	}


}
