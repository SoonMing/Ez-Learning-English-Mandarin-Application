using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour {
    public GameObject username;
    public GameObject password;
    public GameObject login;

    public Button btn_login;

    private string Username;
    private string Password;

    // Use this for initialization
    void Start () {
        Screen.orientation = ScreenOrientation.Landscape;
	}
	
	// Update is called once per frame
	void Update () {
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;

        btn_login = login.GetComponent<Button>();
        btn_login.onClick.AddListener(validateLogin);
    }
    private void validateLogin()
    {
        if (Username != "" && Password != "")
        {
            print("Login Successful");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            print("Login Failed");
        }
    }
     
}
