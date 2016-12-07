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

        Text myCoin = GameObject.Find("coinPlus").GetComponent<Text>();//
        myCoin.text = totCoin.ToString();      // text값인 txtCoin값을 넣어야하나???????????????
        Debug.Log(myCoin.text);               // console창으로 확인
    }
    
         
    
    	
}
