using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class free : MonoBehaviour
{
    public Transform Target;
    private Camera maincamera;
    public GameObject freee;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        if (Target != null)
        {
            //把目标坐标转换为屏幕坐标
            Vector3 pos = maincamera.WorldToScreenPoint(Target.position);
            transform.position = pos;
        }
        
    }
}
