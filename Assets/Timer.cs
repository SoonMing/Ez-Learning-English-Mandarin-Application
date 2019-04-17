using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    // Use this for initialization
    Vector3 initialPosition;
    int attempts = 0;
    public Text attemptsCounter;

    void Start()
    {
        initialPosition = gameObject.transform.position;

    }


    public void Drag()
    {
        GameObject.Find("Apple").transform.position = Input.mousePosition;
    }
    public void Drag1()
    {
        GameObject.Find("Banana").transform.position = Input.mousePosition;
    }
    public void Drag2()
    {
        GameObject.Find("Watermelon").transform.position = Input.mousePosition;
    }
    public void Drag3()
    {
        GameObject.Find("Pineapple").transform.position = Input.mousePosition;
    }
    public void Drag4()
    {
        GameObject.Find("Orange").transform.position = Input.mousePosition;
    }
    public void Drop()
    {
        for (int i = 1; i <= 5; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Apple").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Apple")
                {
                    GameObject.Find("Apple").transform.position = ph1.transform.position;
                    attempts += 1;
                }
                else
                {
                    GameObject.Find("Apple").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop1()
    {
        for (int i = 1; i <= 5; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Banana").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Banana")
                {
                    GameObject.Find("Banana").transform.position = ph1.transform.position;
                    attempts += 1;
                }
                else
                {
                    GameObject.Find("Banana").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop2()
    {
        for (int i = 1; i <= 5; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Watermelon").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Watermelon")
                {
                    GameObject.Find("Watermelon").transform.position = ph1.transform.position;
                    attempts += 1;
                }
                else
                {
                    GameObject.Find("Watermelon").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop3()
    {
        for (int i = 1; i <= 5; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Pineapple").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Pineapple")
                {
                    GameObject.Find("Pineapple").transform.position = ph1.transform.position;
                    attempts += 1;
                }
                else
                {
                    GameObject.Find("Pineapple").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop4()
    {
        for (int i = 1; i <= 5; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Orange").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Orange")
                {
                    GameObject.Find("Orange").transform.position = ph1.transform.position;
                    attempts += 1;
                }
                else
                {
                    GameObject.Find("Orange").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        attemptsCounter.text = "" + attempts;
    }
}
