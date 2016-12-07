using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginHandler : MonoBehaviour
{

    private InputField _pass;
    private InputField _id;

    // Use this for initialization
    void Start()
    {
        InputField _id;
        InputField _pass;
    }
    public void SetPass(InputField inputPw)
    {
        this._pass = inputPw;
    }
    public void SetId(InputField inputId)
    {
        this._id = inputId;
    }
    public void login()
    {
        StartCoroutine(doLogin());
    }

    IEnumerator doLogin()
    {
        string url = "http://52.78.164.46/userLogin.php";
        WWWForm loginData = new WWWForm();
        Text mylogin = GameObject.Find("logText").GetComponent<Text>();
        //mylogin.text = "1111111111111111";

        loginData.AddField("id_data", _id.text);
        loginData.AddField("pass_data", _pass.text);

        WWW login = new WWW(url, loginData);
        yield return login;
        mylogin.text = login.text;
        char sp = '/';
        string[] result = login.text.Split(sp);

        //        if ((mylogin.text=login.text) == "adepterLogin successed")
        if (result[0] == "Success")   // 0=Success, 1=닉네임, 2=코인, 3= 스코어 
        {
            Entity.e.Add(new _e { _s = mylogin.text });
            Application.LoadLevel("MainGameScene");

        }

    }
    // Update is called once per frame
    void Update()
    {
    }

    public void MoveToGameScene()
    {
    }
}