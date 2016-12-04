using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class word : MonoBehaviour {

	public Text txtWord;
	private string totWord = "Pear";
	// Use this for initialization
	void Start () {
		DispWord ("Pear");
	}

	// Update is called once per frame
	public void DispWord(string word)
	{
		totWord = word;
		//SwtartCoroutine(DataMgr.instance.SaveScore(1));
		txtWord.text = " Word : <color=#00FF00>" + totWord.ToString () + "</color>";
	}

}
