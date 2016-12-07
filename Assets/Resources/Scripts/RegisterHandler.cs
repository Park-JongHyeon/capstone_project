using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RegisterHandler : MonoBehaviour
{

    private InputField _pass;
    private InputField _id;
    private InputField _name;

    // Use this for initialization
    void Start()
    {
        InputField _id;
        InputField _pass;
        InputField _name;
    }
    public void SetPass(InputField inputPw)
    {
        this._pass = inputPw;
    }
    public void SetId(InputField inputId)
    {
        this._id = inputId;
    }
    public void SetName(InputField inputName)
    {
        this._name = inputName;
    }

    public void register()
    {
        StartCoroutine(doRegister());
    }

    IEnumerator doRegister()
    {
       string url = "http://52.78.164.46/new.php";
        WWWForm registerData = new WWWForm();
        Text myregister = GameObject.Find("regText").GetComponent<Text>();
       
        registerData.AddField("ID", _id.text);
        registerData.AddField("PW", _pass.text);
        registerData.AddField("Name", _name.text);

        WWW register = new WWW(url, registerData);
        yield return register;
        myregister.text = register.text;
        //char sp = '/';
        //string[] result = login.text.Split(sp);
        string result = register.text;
        myregister.text = register.text;
        //        if ((mylogin.text=login.text) == "adepterLogin successed")
        if (result == "Success")   // 0=Success시 다음 메인으로 
        {
            Application.LoadLevel("LoginScene");

        }
       /* else
        {
            /// 실패했다고 메세지 출력!!
            myregister.text = "실패실패";
        }*/

    }
    // Update is called once per frame
    void Update()
    {
    }

    public void MoveToGameScene()
    {
    }
}