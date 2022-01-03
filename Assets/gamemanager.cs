using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    public int[] rank = new int[10];
    public static float difficulty;

    static string[] a = new string[10];
    static int[] b =new int[10];
    void rank_x(int[] a)
    {
        for (int x = 0; x < a.Length; x++)
        {
            for (int y = 0; y < a.Length; y++)
            {
                if (a[x] > a[y])
                {
                    int box;
                    box = a[y];
                    a[y] = a[x];
                    a[x] = box;
                }
            }
        }
    }
    void insert(int[] a, int b)
    {
        rank_x(a);
        for (int x = 0; x < a.Length; x++)
        {
            if (b > a[x])
            {
                a[a.Length - 1] = b;
            }
        }
        rank_x(a);
    }
    void rank_int_to_string()
    {
        for (int x = 0; x < a.Length; x++)
        {
            a[x] = System.Convert.ToString(b[x]);
        }
    }
    void rank_string_to_int()
    {
        for (int x = 0; x < a.Length; x++)
        {
            b[x] = System.Convert.ToInt32(a[x]);
        }
    }
    public void scorecounter() //记分
    {
        scoreflag = 1;
        if (scoreflag == 1)
        {
            count++;
            scoreflag = 0;
        }
    }
    private void Start()    //启动时打开开始UI
    {   
        contibuttom.SetActive(false);
        RanksCanvas.SetActive(false);
        GameoverCanvas.SetActive(false);
        GamestartCanvas.SetActive(true);
        
    }
    public void Gamestart() //开始游戏，转向场景1
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        count = 0;
    }
    public void GameOver()      //游戏结束打开UI
    {
        overflag = 1;
        GameoverCanvas.SetActive(true);
        Time.timeScale = 0;
        ScoreCanvas.SetActive(true);

        string[] strs = File.ReadAllLines(@"C:\Users\yccx\Desktop\project\demo.txt");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = strs[i];
        }
        insert(b, count);
        rank_int_to_string();
        rank_string_to_int();
        File.WriteAllText(@"C:\Users\yccx\Desktop\project\demo.txt", a[0] + "\r\n" + a[1] + "\r\n" + a[2] + "\r\n" + a[3] + "\r\n" + a[4] + "\r\n" + a[5] + "\r\n" + a[6] + "\r\n" + a[7] + "\r\n" + a[8] + "\r\n" + a[9]);
        string[] strs1 = File.ReadAllLines(@"C:\Users\yccx\Desktop\project\demo.txt");
        ranktext.text = "RANKS" + "\r\n" + strs1[0] + "\r\n" + strs1[1] + "\r\n" + strs1[2] + "\r\n" + strs1[3] + "\r\n" + strs1[4] + "\r\n" + strs1[5] + "\r\n" + strs1[6] + "\r\n" + strs1[7] + "\r\n" + strs1[8] + "\r\n" + strs1[9]+ "\r\n"+"当前分数"+System.Convert.ToString(count);
      

    }
    public void Replay() //重玩按钮
    {
        count = 0;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        ScoreCanvas.SetActive(true);
    }
    public void OnCanvasGroupChanged()   //开始界面可视化
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

    public void backbuttom()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Rankbuttom()
    {
       RanksCanvas.SetActive(true);
    }
    void Update()
    {
    }
}
