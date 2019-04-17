using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterScript : MonoBehaviour {

    public GameObject Register;
    public InputField register_username;
    public InputField register_password;
    public InputField register_confirmPassword;
    public Button btn_register;
    public GameObject message_user;
    public Text message;

    private string urlRegister = "http://lrgs.ftsm.ukm.my/users/a161017/EasyApps/register.php";

    // Use this for initialization
    void Start () {
        register_username.text = "";
        register_password.text = "";
        Screen.orientation = ScreenOrientation.Landscape;
    }
	
	// Update is called once per frame
	
    public void ValidateRegister()
    {
        StartCoroutine(RegisterFunction());
    }
    public IEnumerator RegisterFunction()
    {
        WWWForm form = new WWWForm();

        if (register_username.text != "" && register_username.text.Length > 3 && register_username != null )
        {
            if (register_password.text != "" && register_confirmPassword.text != "" && register_password.text.Length >= 6 && register_password.text.Length <= 15 && register_confirmPassword.text.Length >= 6 && register_confirmPassword.text.Length <= 15 && register_password != null && register_confirmPassword != null)
            {

                if (register_password.text == register_confirmPassword.text)
                {

                    form.AddField("username", register_username.text);
                    form.AddField("password", register_password.text);


                    WWW download = new WWW(urlRegister, form);
                    yield return download;
                    print(download.text);

                    if (!string.IsNullOrEmpty(download.error))
                    {
                        print("Register error. Error: " + download.error);
                        
                    }

                    else
                    {
                        if (download.text == "Done")
                        {
                            print("New Account is created");
                            SceneManager.LoadScene("Interface2");

                        }
                    }
                }

                else
                {
                    print("wrong password");
                    message.text = "Password does not match!";
                    message_user.SetActive(true);
                }
            }

            else
            {
                if (register_password.text.Length >0 && register_password.text.Length < 6)
                {
                    message.text = "Please insert a longer password";
                }
                else if (register_password.text.Length > 15)
                {
                    message.text = "Please insert a shorter password";
                }
                else
                {
                    message.text = "Password cannot be blank!";
                    message_user.SetActive(true);
                }
            }
        }

        else
        {
            if (register_username.text.Length >0 && register_username.text.Length < 3)
            {
                message.text = "Please insert a longer username";
            }
            else
            {
                message.text = "Username cannot be blank!";
                message_user.SetActive(true);
            }
        }



    }
}
