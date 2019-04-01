using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Targetmenu : MonoBehaviour {

   public int i = 1, l, r;
    public int re=0;
    public bool s = false;
    
    

    private void Start()
    {
       
    }

  

    
    private void Update()
    {
         l= Leftscore.leftsc;
         r =Rightscore.rightscore;
        if(l==i)
        {
            GameObject.Find("Canvas").transform.Find("resultimg").gameObject.SetActive(true);
            re = 1;
       
        }

        if(r==i)
        {
            GameObject.Find("Canvas").transform.Find("resultimg").gameObject.SetActive(true);
            re = 2;
      
        }
    }

    public void ten()
    {
        i = 10;
        work();
    }

    public void twenty()
    {
        i = 20;
        work();
    }

    public void twentyfive()
    {
        i = 25;
        work();
    }

    public void thirty()
    {
        i = 30;
        work();
    }


    void work()
    {
        GameObject.Find("Canvas").transform.Find("targetmenu").gameObject.SetActive(false);
        gameObject.GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
        s = true;
        GameObject.Find("levelobj").GetComponent<AudioSource>().Stop();
        Invoke("play", 2);

    }

    public void home()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.Find("levelobj"));

    }

    void play()
    {
        GameObject.Find("Background").GetComponent<AudioSource>().Play();
    }
}
