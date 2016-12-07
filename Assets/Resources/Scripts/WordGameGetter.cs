using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WordGameGetter : MonoBehaviour {

    // Use this for initialization
    string[] result;
    string data;
    char sp = '/';
    // Use this for initialization
    void Start()
    {
        foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split(sp);
        }
        Text prevCoin = GameObject.Find("coinValue").GetComponent<Text>();
        prevCoin.text = result[2];       // 0=Success, 1=닉네임, 2=코인, 3= 스코어
        Debug.Log(prevCoin.text);
    }


    // Update is called once per frame
    void Update () {
	
	}
}
