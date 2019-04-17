using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    Text scores;

    int score;

	// Use this for initialization
	void Start () {

        scores = GameObject.Find("Scores").GetComponent<Text>();

        score = PlayerPrefs.GetInt("CurrentScore");
        scores.text = "你答对了 " + score + "题\n" + "You answered " + score + " questions correctly.";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
