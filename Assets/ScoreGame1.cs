using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGame1 : MonoBehaviour {

    // Use this for initialization
    public static Text Attempts;
    void Start () {
        Attempts = GameObject.Find("Scores").GetComponent<Text>();
        Attempts.text = "你用了 " + attempt.total + "次正确地回答所有问题" + "You used " + attempt.total + " attempts to answer all the questions correctly.";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
