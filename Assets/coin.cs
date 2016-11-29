using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coin : MonoBehaviour {

	public Text txtCoin;
	private int totCoin = 0;
	// Use this for initialization
	void Start () {
		DispCoin (0);
	}
	
	// Update is called once per frame
	public void DispCoin(int coin)
	{
		totCoin += coin;
		//StartCoroutine(DataMgr.instance.SaveScore(1));
		txtCoin.text = "coin <color=#ffff00>" + totCoin.ToString () + "</color>";
	}
		
}
