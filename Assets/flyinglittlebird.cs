
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyinglittlebird : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    public gamemanager gamemanager;
    public GameObject ScoreCanvas;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             rb.velocity = Vector2.up * velocity;
            Animator anim = this.GetComponent<Animator>();
            anim.SetBool("oneclick", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        gamemanager.GameOver();
        ScoreCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamemanager.scorecounter();
    }

    private void oneclickcancel() 
    {
        Animator anim = this.GetComponent<Animator>();
        anim.SetBool("oneclick", false);
    }
}
 