using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe0;
    public GameObject pipe1;
    public GameObject pipe2;
    public GameObject pipe3;
    public float height;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        num = Mathf.Abs(Random.Range(-1,4));
        if (timer > maxTime) 
        {
            switch (num)
            {
                case 0:
                    GameObject newpipe0 = Instantiate(pipe0);
                    newpipe0.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe0, 15);
                    timer = 0;
                    break;
                case 1:
                    GameObject newpipe1 = Instantiate(pipe1);
                    newpipe1.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe1, 15);
                    timer = 0;
                    break;
                case 2:
                    GameObject newpipe2 = Instantiate(pipe2);
                    newpipe2.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe2, 15);
                    timer = 0;
                    break;
                case 3:
                    GameObject newpipe3 = Instantiate(pipe3);
                    newpipe3.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
                    Destroy(newpipe3, 15);
                    timer = 0;
                    break;
            }
        }
        timer += Time.deltaTime;
    }
}
