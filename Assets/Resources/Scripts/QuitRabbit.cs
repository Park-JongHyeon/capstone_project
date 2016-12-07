using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuitRabbit : MonoBehaviour {

    // Use this for initialization
    string[] result;
    string timeValue;
    string data;
    char sp = '/';
    

    void Start()
    {

        foreach (_e x in Entity.e)
        {
            //data = x._s;
            Debug.Log(x._s);
            result = x._s.Split(sp);
        }
    }

    // Update is called once per frame

    public void score()
    {
        StartCoroutine(doScore());
    }

    IEnumerator doScore()
    {
        Text textTime = GameObject.Find("timeValue").GetComponent<Text>();
        timeValue = textTime.text;
        string url = "http://52.78.164.46/scoreUpdate.php";
        WWWForm scoreData = new WWWForm();

        scoreData.AddField("Nick", result[1]);
        scoreData.AddField("SCORE", timeValue);

        WWW score = new WWW(url, scoreData);
        yield return score;
    }

    public void MoveToMainScene()
    {
        // DestroyObject(Entity.e[0]);
        /*Entity.e.RemoveAt(0);
        Entity.e.Add(new _e { _s = renew_result });*/

        Application.LoadLevel("MainGameScene");
    }
}
