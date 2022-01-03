using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public GameObject GameoverCanvas;
    public GameObject GamestartCanvas;
    public GameObject ScoreCanvas;
    public GameObject RanksCanvas;
    public Text ranktext;
    public GameObject contibuttom;
    public static int scoreflag=0,count=0;
    public static int overflag=0,startflag=0,stopflag=0;
    public int[] rank = new int[11];
    private void Start()    //����ʱ�򿪿�ʼUI
    {   
        contibuttom.SetActive(false);
        RanksCanvas.SetActive(false);
        GameoverCanvas.SetActive(false);
        GamestartCanvas.SetActive(true);
        
    }
    public void Gamestart() //��ʼ��Ϸ��ת�򳡾�1
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void GameOver()      //��Ϸ������UI
    {
        overflag = 1;
        GameoverCanvas.SetActive(true);
        Time.timeScale = 0;
        ScoreCanvas.SetActive(true);
        ScoreRanks();
    }
    public void Replay() //���水ť
    {
        count = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        ScoreCanvas.SetActive(true);
    }
    public void ScoreRanks()
    {
        if(overflag==1)
        {
            rank[0] = count;
            ranktext.text = "" + System.Convert.ToString(rank[0]);
        }


    }
    public void scorecounter() //�Ƿ�
    {
        scoreflag = 1;
        if (scoreflag == 1)
        {
            count++;
            scoreflag = 0;
        }
    }


    public void OnCanvasGroupChanged()   //��ʼ������ӻ�
    {
        GamestartCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void Stopbuttom()
    {
        Time.timeScale = 0;
        contibuttom.SetActive(true);
        stopflag = 1;
    }
    public void Startbuttom()
    {
        Time.timeScale = 1;
        stopflag = 0;
        contibuttom.SetActive(false);
    }

    public void Rankbuttom()
    {
       RanksCanvas.SetActive(true);
    }
    void Update()
    {
    }

}
