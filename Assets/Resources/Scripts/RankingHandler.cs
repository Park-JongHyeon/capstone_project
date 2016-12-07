/*using UnityEngine;
using System.Collections;

public class RankingHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split(sp); // 0=Success, 1=닉네임, 2=코인, 3= 스코어
        }
    }

    // Update is called once per frame

    public void Rank()
    {
        StartCoroutine(doGetInfo());
    }

    IEnumerator doRank()
    {
        Text myRank = GameObject.Find("MyRanking").GetComponent<Text>();
        Text TotRank = GameObject.Find("TotalRanking").GetComponent<Text>();
        string url = "http://52.78.164.46/loadRanking.php";
        WWWForm infoData = new WWWForm();

        string[] nick;
        string resultInfo;
        string[] value;
        // string nick;

        foreach (_e x in Entity.e)
        {
            Debug.Log(x._s);
            nick = x._s.Split('/');
            //infoData.AddField("Nick", nick[1]);       ////       2번이나 3번 보내질수도 있다// 원래 괄호 밖으로 빼야 정상
        }
        //nick = Entity.e._s.pop();
        infoData.AddField("Nick", result[1]);
        Debug.Log("result[1] : " + result[1]);

        WWW info = new WWW(url, infoData);
        yield return info;
        Debug.Log("info : " + info.text);
        resultInfo = info.text;
        char sp = '/';
        value = resultInfo.Split(sp);

        myCoin.text = value[0];
        myScore.text = value[1];

    }

}*/
