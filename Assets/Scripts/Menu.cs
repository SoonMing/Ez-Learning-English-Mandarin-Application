using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

public void NextButton(string scenname)
    {
        SceneManager.LoadScene(scenname);
    }
    public void BackButton(string scenname)
    {
        SceneManager.LoadScene(scenname);
    }
    public void Home()
    {
        SceneManager.LoadScene("Scene1");
    }
}
