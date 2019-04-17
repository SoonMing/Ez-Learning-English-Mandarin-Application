using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene : MonoBehaviour {
    public void ToThisScene (string scene)
    {
        SceneManager.LoadScene(scene);
    }
	
}
