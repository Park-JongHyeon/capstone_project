using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RankingHandler : MonoBehaviour {

    string[] result;
	// Use this for initialization
	void Start () {
        foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split('/'); // 0=Success, 1=닉네임, 2=코인, 3= 스코어
        }
        Rank();
    }

    // Update is called once per frame

    public void Rank()
    {
        StartCoroutine(doRank());
    }

    IEnumerator doRank()
    {
//        Text myRank = GameObject.Find("MyRanking").GetComponent<Text>();
        //Text rank2 = GameObject.Find("rank2").GetComponent<Text>();
        Text rank3 = GameObject.Find("rank3").GetComponent<Text>();
        string url = "http://52.78.164.46/showMyrank.php";
        WWWForm rankData = new WWWForm();

    

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
        Debug.Log(result[1]);
        rankData.AddField("Nick", result[1]);
        WWW rank = new WWW(url, rankData);
        yield return rank;
        //rank2.text = result[1];
        rank3.text = rank.text;
        char sp = '/';
        //value = myRank.text.Split(sp);


    }

}
