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
    private void Start()    //启动时打开开始UI
    
    {
        GameoverCanvas.SetActive(false);
        GamestartCanvas.SetActive(true);
    }

    public void GameOver()      //游戏结束打开UI
    { 
        GameoverCanvas.SetActive(true);
        Time.timeScale = 0;
        ScoreCanvas.SetActive(false);
    }
    
    public void scorecounter() //记分
    {
        flag=1;
        if (flag == 1)
        {
            count++;
            flag = 0;
        }
    }
    public void Gamestart() //开始游戏，转向场景1
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
       
    }

    public void OnCanvasGroupChanged()   //开始界面可视化
    {
        GamestartCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void Replay() //重玩按钮
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
