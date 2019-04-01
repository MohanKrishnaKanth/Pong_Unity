using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause : MonoBehaviour {
    GameObject canv;
     GameObject bal;
    public GameObject ball;
    Vector3 v1;
    Vector3 v2;
    Vector3 v;
    GameObject[] gameobj;
    private void Start()
    {
        canv = GameObject.Find("Canvas");
       
        v1.x = -6.94f;
        v1.y = -0.07f;
        v1.z = -5.26f;
        v2.x = 7.09f;
        v2.y = -0.17f;
        v2.z = 1.74f;
   
        v = Vector2.zero;
        v.z = -1;
    }
    public void pausemenu()
    {
        Time.timeScale = 0f;
        canv.transform.Find("pausemenu").gameObject.SetActive(true);
        canv.transform.Find("pausebutton").gameObject.SetActive(false);
    }

    public void restart()
    {
        Destroy(GameObject.FindGameObjectWithTag("Ball"));
        Time.timeScale = 0f;
        canv.transform.Find("pausemenu").gameObject.SetActive(false);
        canv.transform.Find("pausebutton").gameObject.SetActive(true);
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

    public void resume()
    {
        Time.timeScale = 1f;
        canv.transform.Find("pausemenu").gameObject.SetActive(false);
        canv.transform.Find("pausebutton").gameObject.SetActive(true);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.FindGameObjectWithTag("Ball"));
        Leftscore.leftsc = 0;
        Rightscore.rightscore = 0;
        GameObject.Find("Leftplayer").transform.position = v1;
        GameObject.Find("Rightplayer").transform.position = v2;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().s = false;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().i = 1;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().l = 0;
        GameObject.Find("Targetmenu").GetComponent<Targetmenu>().r = 0;
        GameObject.Find("GameController").GetComponent<Gamecontroller>().b.SetActive(false);
        GameObject.Find("GameController").GetComponent<Gamecontroller>().c.SetActive(false);
        GameObject.Find("GameController").GetComponent<Gamecontroller>().d.SetActive(false);
        Destroy(GameObject.Find("levelobj"));
        GameObject.Find("Leftplayer").GetComponent<SpriteRenderer>().color = Color.white;
        GameObject.Find("Rightplayer").GetComponent<SpriteRenderer>().color = Color.white;
        foreach (GameObject vball in gameobj)
        {
            GameObject.Destroy(vball);
        }

    }

    private void Update()
    {
        bal = GameObject.FindGameObjectWithTag("Ball");
       if(bal==false)
        {
           if(GameObject.Find("GameController").GetComponent<Gamecontroller>().ch==3)
            {
                Instantiate(ball, new Vector2(0,-2.5f), Quaternion.identity);
            }
           else
            {
                Instantiate(ball, v, Quaternion.identity);
            }
        }

        gameobj = GameObject.FindGameObjectsWithTag("vball");
    }

}
