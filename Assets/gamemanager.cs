using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject GameoverCanvas;
    public GameObject GamestartCanvas;
    public GameObject ScoreCanvas;
    public static int flag=0,count=0;
    private void Start()    //����ʱ�򿪿�ʼUI
    
    {
        GameoverCanvas.SetActive(false);
        GamestartCanvas.SetActive(true);
    }

    public void GameOver()      //��Ϸ������UI
    { 
        GameoverCanvas.SetActive(true);
        Time.timeScale = 0;
        ScoreCanvas.SetActive(false);
    }
    
    public void scorecounter() //�Ƿ�
    {
        flag=1;
        if (flag == 1)
        {
            count++;
            flag = 0;
        }
    }
    public void Gamestart() //��ʼ��Ϸ��ת�򳡾�1
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
       
    }

    public void OnCanvasGroupChanged()   //��ʼ������ӻ�
    {
        GamestartCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Replay() //���水ť
    {
        count = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        ScoreCanvas.SetActive(true);
    }

    public void Stopbuttom()
    {
        Time.timeScale = 0;

    }

    void Update()
    {
    }

}
