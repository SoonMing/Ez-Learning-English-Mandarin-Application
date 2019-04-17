using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attempt : MonoBehaviour
{

    // Use this for initialization
    public Text attemptsCounter;
    public static Text total;

    private string urlScore = "http://lrgs.ftsm.ukm.my/users/a161017/EasyApps/game1.php";

    // Update is called once per frame
    void Update()
    {
        attemptsCounter.text = "" + ManageDrapAndDrop.attempts;
        total = attemptsCounter;
    }

    public IEnumerator Score()
    {
        WWWForm form = new WWWForm();
        form.AddField("score", total.text);

        WWW download = new WWW(urlScore, form);
        yield return download;
        print(download.text);
    }
}
