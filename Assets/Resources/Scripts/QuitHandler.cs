using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class QuitHandler : MonoBehaviour {

    // Use this for initialization
    string[] result;
    string renew_result;
    string renew_coin;
    string data;
    char sp = '/';
    

    void Start() {

    }

    // Update is called once per frame

    public void retransmit()
    {
        StartCoroutine(doRetransmit());
    }

    IEnumerator doRetransmit()
    {
        foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split(sp);
        }
        Text newCoin = GameObject.Find("coinPlus").GetComponent<Text>();
        Text prevCoin = GameObject.Find("coinValue").GetComponent<Text>();

        renew_coin = (int.Parse(newCoin.text) + int.Parse(prevCoin.text)).ToString();
        //renew_coin = (int.Parse("20") + int.Parse("5")).ToString();

        renew_result = result[0] +"/"+ result[1] +"/"+ renew_coin +"/"+ result[3];
        Debug.Log("new : " + newCoin.text + "   prev : " + prevCoin.text);
        Debug.Log("total result : " + renew_result);


        string url = "http://52.78.164.46/coinUpdate.php";
        WWWForm retData = new WWWForm();
        Debug.Log("result[1]=" + result[1] + "  renew_coin : " + renew_coin);
        retData.AddField("Nick", renew_result[1]);
        retData.AddField("COIN", renew_coin);

        WWW ret = new WWW(url, retData);
        yield return ret;

        Debug.Log("nick and coin = " +ret.text);
/*        Entity.e.RemoveAt(0);
        Entity.e.Add(new _e { _s = renew_result });

        Application.LoadLevel("MainGameScene");*/

    }

    public void MoveToMainScene()
    {
        // DestroyObject(Entity.e[0]);
        Entity.e.RemoveAt(0);
        Entity.e.Add(new _e { _s = renew_result });

        Application.LoadLevel("MainGameScene");
        
    }
}
