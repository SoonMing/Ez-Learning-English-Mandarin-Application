using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class ParentsLogin : MonoBehaviour
{
    public GameObject Login;
    public InputField login_username;
    public InputField login_password;
    public Button btn_login;
    public GameObject message_user;
    public Text message;

    private string urlLogin = "http://lrgs.ftsm.ukm.my/users/a161017/EasyApps/login.php";

    public void start()
    {
        login_username.text = "";
        login_password.text = "";
        Screen.orientation = ScreenOrientation.Landscape;

    }

    public void ValidateLogin()
    {
        StartCoroutine(LoginFunction());
    }

    public IEnumerator LoginFunction()
    {
        if (login_username.text == "" || login_password.text == "")
        {
            message.text = "Wrong Username or Password!";
            message_user.SetActive(true);
        }


        WWWForm form = new WWWForm();


        form.AddField("username", login_username.text);
        form.AddField("password", login_password.text);



        WWW download = new WWW(urlLogin, form);
        yield return download;

        if (!string.IsNullOrEmpty(download.error))
        {
            print("Login error. Error: " + download.error);
            message_user.SetActive(true);
            message.text = "Please check your internet connection!";

        }

        else
        {

            if (download.text == "notMatch")
            {
                print("Login error! Please check your username or password.");
                message.text = "Wrong Username or Password!";
                message_user.SetActive(true);


            }
            else
            {
                print("success");
                print(download.text);
                SceneManager.LoadScene("");
            }
        }
    }


}
