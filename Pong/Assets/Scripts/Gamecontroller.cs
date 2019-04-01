using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour {
    Vector3 v1;
    Vector3 v2;
    public int ch;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public bool levthree = false;
    public bool a = false;
    public bool levtwo = false;
    public bool levfour = false;
    GameObject[] gameobj;
    public GameObject p1;
    public GameObject p2;
   public  Color[] colors;
    private void Start()
    {
        v1.x = -6.94f;
        v1.y = -0.07f;
        v1.z = -5.26f;
        v2.x = 7.09f;
        v2.y = -0.17f;
        v2.z = 1.74f;

        p1 = GameObject.Find("Leftplayer");
        p2 = GameObject.Find("Rightplayer");
  
    }

   

 
    private void Update()
    {
        ch = GameObject.Find("levelobj").GetComponent<levelobj>().n;
        if(ch==2)
        {
            levtwo = true;
            create();
            p1.GetComponent<SpriteRenderer>().color = colors[0];
            p2.GetComponent<SpriteRenderer>().color = colors[1];
        }
       
       else if(ch==3)
        {
            levthree = true;
            create2();
            p1.GetComponent<SpriteRenderer>().color = colors[2];
            p2.GetComponent<SpriteRenderer>().color = colors[3];
        }

       else if (ch==4)
        {
            
            levfour = true;
            create3();
            p1.GetComponent<SpriteRenderer>().color = colors[4];
            p2.GetComponent<SpriteRenderer>().color = colors[5];
        }

        gameobj = GameObject.FindGameObjectsWithTag("vball");
    }

    private void create()
    {
        if (levtwo==true&&a==false&&b==true)
        {
          b.SetActive(true);
            levtwo = false;
            a = true;
        }
    }

    void create2()
    {
        if(levthree==true&&a==false && c == true)
        {
            c.SetActive(true);
            levthree = false;
            a = true;
        }
    }

    void create3()
    {
        if(levfour==true && a==false && d==true)
        {

            d.SetActive(true);
            
            levfour = false;
                a= true;
        }
    }

    public void restart()
    {
        Destroy(GameObject.FindGameObjectWithTag("Ball"));
        GameObject.Find("Canvas").transform.Find("resultimg").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("targetmenu").gameObject.SetActive(true);
        Leftscore.leftsc = 0;
        Rightscore.rightscore = 0;
        GameObject.Find("Leftplayer").transform.position = v1;
        GameObject.Find("Rightplayer").transform.position = v2;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().s = false;
        foreach (GameObject vball in gameobj)
        {
            GameObject.Destroy(vball);
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.FindGameObjectWithTag("Ball"));
        Leftscore.leftsc = 0;
        Rightscore.rightscore = 0;
        GameObject.Find("Leftplayer").transform.position = v1;
        GameObject.Find("Rightplayer").transform.position = v2;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().i = 1;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().l = 0;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().r = 0;
        GameObject.Find("Leftplayer").GetComponent<SpriteRenderer>().color = Color.white;
        GameObject.Find("Rightplayer").GetComponent<SpriteRenderer>().color = Color.white;
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        Destroy(GameObject.Find("levelobj"));
        foreach (GameObject vball in gameobj)
        {
            GameObject.Destroy(vball);
        }
    }
}
