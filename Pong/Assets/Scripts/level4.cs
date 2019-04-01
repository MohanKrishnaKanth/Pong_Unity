using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level4 : MonoBehaviour {
    public GameObject boll;
    Vector3 nv;

    bool a = false;
    bool b = false;
    bool h = true;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Ball") == true)
        {
            a = true;
            nv = GameObject.FindGameObjectWithTag("Ball").transform.position;
        }

        create();
        if (GameObject.FindGameObjectWithTag("Ball") == false)
        {
            b = false;
        }
        h = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().v;
    }


    
    void create()
    {
       if(a==true && b==false)
        {
            b = true;
            InvokeRepeating("newcreate", 5,4);
           
           
        }
    }

    void newcreate()
    {
       if(h==false)
        {
            Instantiate(boll, nv, Quaternion.identity);
        }
        
    }
}
