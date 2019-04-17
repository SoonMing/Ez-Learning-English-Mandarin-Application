using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageDrapAndDrop : MonoBehaviour {

    // Use this for initialization
    Vector3 initialPosition;
    public static int attempts = 0;
    public static int count = 0;

    void Start () {
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
        GameObject.Find("Two").transform.position = Input.mousePosition;
    }
    public void Drag3()
    {
        GameObject.Find("Orange").transform.position = Input.mousePosition;
    }
    public void Drag4()
    {
        GameObject.Find("Five").transform.position = Input.mousePosition;
    }
    public void Drag5()
    {
        GameObject.Find("Ten").transform.position = Input.mousePosition;
    }
    public void Drag6()
    {
        GameObject.Find("Mouth").transform.position = Input.mousePosition;
    }
    public void Drag7()
    {
        GameObject.Find("Nose").transform.position = Input.mousePosition;
    }
    public void Drag8()
    {
        GameObject.Find("Car").transform.position = Input.mousePosition;
    }
    public void Drag9()
    {
        GameObject.Find("Van").transform.position = Input.mousePosition;
    }
    public void Drop()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Apple").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Apple")
                {
                    GameObject.Find("Apple").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                    
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
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Banana").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Banana")
                {
                    GameObject.Find("Banana").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
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
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Two").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Two")
                {
                    GameObject.Find("Two").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Two").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop3()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Orange").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Orange")
                {
                    GameObject.Find("Orange").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Orange").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }
    }
    public void Drop4()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Five").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Five")
                {
                    GameObject.Find("Five").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Five").transform.position = initialPosition;
                    attempts += 1;
                }   
                }
        }
        
    }
    public void Drop5()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Ten").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Ten")
                {
                    GameObject.Find("Ten").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Ten").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    public void Drop6()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Mouth").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Mouth")
                {
                    GameObject.Find("Mouth").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Mouth").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    public void Drop7()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Nose").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Nose")
                {
                    GameObject.Find("Nose").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Nose").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    public void Drop8()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Car").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Car")
                {
                    GameObject.Find("Car").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Car").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    public void Drop9()
    {
        for (int i = 1; i <= 10; i++)
        {
            GameObject ph1 = GameObject.Find("Placeholder" + i);
            float distance = Vector3.Distance(GameObject.Find("Van").transform.position, ph1.transform.position);
            if (distance < 200)
            {
                if (ph1.tag == "Van")
                {
                    GameObject.Find("Van").transform.position = ph1.transform.position;
                    attempts += 1;
                    count += 1;
                }
                else
                {
                    GameObject.Find("Van").transform.position = initialPosition;
                    attempts += 1;
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        if(count == 10)
        {
            SceneManager.LoadScene("ScoreGame1");
        }
    }
}
