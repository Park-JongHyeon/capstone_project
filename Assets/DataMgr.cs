using UnityEngine;
using System.Collections;

public class DataMgr : MonoBehaviour {

    public static DataMgr instance = null;
    private const string link = "http://52.78.164.46/coin.php";

    // Use this for initialization

    void Awake()
    {
        instance = this;
    }
    
    public IEnumerator SaveScore(int coinCount)
    {
        WWWForm form = new WWWForm();
        form.AddField("Coin", coinCount);

        var www = new WWW(link, form);

        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.text);
        }else
        {
            Debug.Log("Error : " + www.error);
        }
    }

}
