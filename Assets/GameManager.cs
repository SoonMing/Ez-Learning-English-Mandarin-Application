using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [System.Serializable]
    public class Question
    {
        [Header("Question")]
        public Sprite imageQuestion;

        [Header("Option")]
        public string optionA, optionB, optionC, optionD;

        [Header("Answer")]
        public bool A, B, C, D;
    }
   
    [SerializeField]
    private float timeBtwQuestion = 1f;

    public int score;
    private int randomQuestionIndex;
    Image picQuestion;
    Text textA, textB, textC, textD, scores, quesNo;
   
    public List<Question> QuestionGroup;
    private Question currentQuestion;

    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign;

    void Start()
    {
        //Finding game objects with tags "ToEnable" & "ToDisable"
        toEnable = GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable = GameObject.FindGameObjectsWithTag("ToDisable");

        //Disabling game objects with tag "ToEnable"
        foreach (GameObject element in toEnable)
        {
            element.gameObject.SetActive(false);
        }

        quesNo = GameObject.Find("Question No.").GetComponent<Text>();
        picQuestion = GameObject.Find("Image").GetComponent<Image>();
        textA = GameObject.Find("Button TextA").GetComponent<Text>();
        textB = GameObject.Find("Button TextB").GetComponent<Text>();
        textC = GameObject.Find("Button TextC").GetComponent<Text>();
        textD = GameObject.Find("Button TextD").GetComponent<Text>();
        scores = GameObject.Find("Scores").GetComponent<Text>();

        randomQuestionIndex = Random.Range(0, QuestionGroup.Count);

    }

    void Update()
    {
        if (QuestionGroup.Count > 0) //1 = total questions you want to set(prepare 10 questions, but just set 5 questions in 1 quiz)
        {
            int quesNum = QuestionGroup.Count;
            //int quesNums = quesNum - (quesNum --);
            quesNo.text = "Questions Left: " + (quesNum);
            picQuestion.sprite = QuestionGroup[randomQuestionIndex].imageQuestion;
            textA.text = QuestionGroup[randomQuestionIndex].optionA;
            textB.text = QuestionGroup[randomQuestionIndex].optionB;
            textC.text = QuestionGroup[randomQuestionIndex].optionC;
            textD.text = QuestionGroup[randomQuestionIndex].optionD;
        }
        else if (QuestionGroup.Count <= 0 && score == 20)
        {
            PlayerPrefs.SetInt("CurrentScore", score);
            SceneManager.LoadScene("PerfectScore", LoadSceneMode.Single);
        }

        else if (QuestionGroup.Count <= 0 && score < 20)
        {
            PlayerPrefs.SetInt("CurrentScore", score);
            SceneManager.LoadScene("Score", LoadSceneMode.Single);
        }
    }
   
    public void AnsCheck(string answer)
    {
        if (QuestionGroup[randomQuestionIndex].A == true && answer == "a")
        {
            score++;

            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "correct" sign
            correctSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }

        else if (QuestionGroup[randomQuestionIndex].A == true && answer != "a")
        {
            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "incorrect" sign
            incorrectSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }
       
        if (QuestionGroup[randomQuestionIndex].B == true && answer == "b")
        {
            score++;

            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "correct" sign
            correctSign.SetActive(true);
           // GetComponent.<AudioSource>().PlayOneShot(CorrectSound);

            Invoke("LoadNextQuestion", 1f);
        }

        else if (QuestionGroup[randomQuestionIndex].B == true && answer != "b")
        {
            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "incorrect" sign
            incorrectSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }
        
        if (QuestionGroup[randomQuestionIndex].C == true && answer == "c")
        {
            score++;

            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "correct" sign
            correctSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }

        else if (QuestionGroup[randomQuestionIndex].C == true && answer != "c")
        {
            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "incorrect" sign
            incorrectSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }
       
        if (QuestionGroup[randomQuestionIndex].D == true && answer == "d")
        {
            score++;

            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "correct" sign
            correctSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);
        }

        else if (QuestionGroup[randomQuestionIndex].D == true && answer != "d")
        {
            //Disabling game objects that are no longer needed
            foreach (GameObject element in toDisable)
            {
                element.gameObject.SetActive(false);
            }

            //Turn on "incorrect" sign
            incorrectSign.SetActive(true);

            Invoke("LoadNextQuestion", 1f);            
        }
    }

    void LoadNextQuestion()
    {
        correctSign.SetActive(false);
        incorrectSign.SetActive(false);
    
        //To prevent ans repeated question in one quiz
        QuestionGroup.RemoveAt(randomQuestionIndex);
        randomQuestionIndex = Random.Range(0, QuestionGroup.Count);

        foreach (GameObject element in toDisable)
        {
            element.gameObject.SetActive(true);
        }
    }
}
        
      
