using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "00";
    }
    // Update is called once per frame
    void Update()
    {
        if (gamemanager.stopflag == 1)
        {
            Stopcount();
        }
        else
        {
            ScoreText.text = "" + gamemanager.count;
        }
    }
    public void Stopcount()
    {
        ScoreText.text = "STOP";
    }
}
