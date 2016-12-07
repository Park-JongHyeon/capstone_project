using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveToRabbitGame : MonoBehaviour {

    string[] result;
    int cococoin;
	// Use this for initialization
	void Start () {
	
	}

    public void MoveToRabbitScene()
    {
        foreach (_e x in Entity.e)
        {
            Debug.Log(x._s);
            result = x._s.Split('/'); // 0=Success, 1=닉네임, 2=코인, 3= 스코어
            cococoin = int.Parse(result[2]) - 1;
            Debug.Log("cococoin000 =" + cococoin);
        }
        if (int.Parse(result[2]) > 1)
        {
            Coin(result[1],cococoin);
            Application.LoadLevel("RabbitScene");
        }
        else
        {
            Text check = GameObject.Find("check").GetComponent<Text>();
            check.text = "You don't have coin";
            Debug.Log(check.text);
        }
    }

    public void Coin(string res,int cococoin)
    {
        StartCoroutine(doCoin(res,cococoin));
    }

    IEnumerator doCoin(string res, int cococoin)
    {
        //int afterCoin;
        string test;
        //string[] result2;
        Text myCoin = GameObject.Find("scoreVal").GetComponent<Text>();
        string url = "http://52.78.164.46/coinUpdate.php";
        WWWForm coinData = new WWWForm();
        //afterCoin = (int.Parse(myCoin.text)) - 1;
        //test = "" + afterCoin;

        Debug.Log("res = " + res);
        //Debug.Log("afterCoin = "+ test);
        /*foreach (_e x in Entity.e)
        {
            Debug.Log(x._s);
            result2 = x._s.Split('/'); // 0=Success, 1=닉네임, 2=코인, 3= 스코어
        }*/
        Debug.Log("cococoin1 = " + cococoin);
        coinData.AddField("Nick", res);
        //coinData.AddField("COIN", afterCoin);
        //coinData.AddField("COIN", int.Parse(myCoin.text) - 1);
        coinData.AddField("COIN", cococoin);
        //test = ((int.Parse(myCoin.text)) - 1) + "";
        Debug.Log("cococoin2 = "+ cococoin);
        WWW coin = new WWW(url, coinData);
        yield return coin;
    }



    // Update is called once per frame

}
