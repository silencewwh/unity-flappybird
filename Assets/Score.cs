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
        ScoreText.text = "" + gamemanager.count;
    }
    void stopcount() 
    {

        ScoreText.text = "STOP";
    }
}
