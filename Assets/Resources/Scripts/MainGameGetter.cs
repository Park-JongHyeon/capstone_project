using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainGameGetter : MonoBehaviour {

        //Text mylogin = GameObject.Find("logText").GetComponent<Text>();
    static string[] result;
    string data;
    char sp = '/';
    Text myCoin = GameObject.Find("conVal").GetComponent<Text>();
    Text myScore = GameObject.Find("scoreVal").GetComponent<Text>();
    // Use this for initialization
    void Start () {
	foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split(sp);
        }
        Text myTitle = GameObject.Find("Title").GetComponent<Text>();
        myTitle.text = result[1] + "님 환영합니다";       // 0=Success, 1=닉네임, 2=코인, 3= 스코어
    }


    public void getInfo()
    {
        StartCoroutine(doGetInfo());
    }

    IEnumerator doGetInfo()
    {
        string url = "http://52.78.164.46/userInfo.php";
        WWWForm infoData = new WWWForm();
        
        string[] nick;
        string resultInfo;
        string[] value;
       // string nick;

        foreach (_e x in Entity.e)
        {
            Debug.Log(x._s);
            nick = x._s.Split('/');
            infoData.AddField("Nick", nick[1]);       ////       2번이나 3번 보내질수도 있다// 원래 괄호 밖으로 빼야 정상
        }
       
        WWW info = new WWW(url, infoData);
        yield return info;
        resultInfo = info.text;
        char sp = '/';
        value = resultInfo.Split(sp);

        myCoin.text = value[0];
        myScore.text = value[1];

    }


    // Update is called once per frame
    void Update () {
    }
}
