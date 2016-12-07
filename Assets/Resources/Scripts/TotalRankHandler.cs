using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TotalRankHandler : MonoBehaviour {

    string[] result;
    // Use this for initialization
    void Start()
    {
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
//        Text totRank = GameObject.Find("TotalRank").GetComponent<Text>();
        Text rank5 = GameObject.Find("rank5").GetComponent<Text>();
        Text rank6 = GameObject.Find("rank6").GetComponent<Text>();
        Text rank8 = GameObject.Find("rank8").GetComponent<Text>();
        Text rank9 = GameObject.Find("rank9").GetComponent<Text>();
        Text rank11 = GameObject.Find("rank11").GetComponent<Text>();
        Text rank12 = GameObject.Find("rank12").GetComponent<Text>();

        string url = "http://52.78.164.46/loadRanking.php";
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
        value = rank.text.Split('/');

        rank5.text = value[0];
        rank6.text = value[1];
        rank8.text = value[2];
        rank9.text = value[3];
        rank11.text = value[4];
        rank12.text = value[5];

        //value = myRank.text.Split(sp);


    }

}
