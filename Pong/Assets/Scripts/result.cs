using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result : MonoBehaviour {
    public Text t;
    public int res = 0;
	// Use this for initialization
	void Start () {
        t = GetComponent<Text>();
            
     }
	
	// Update is called once per frame
	void Update () {
        res = GameObject.Find("Targetmenu").GetComponent<Targetmenu>().re;

        if(res==1)
        {
            GameObject.Find("Background").GetComponent<AudioSource>().Stop();
            t.text = "" + "LEFT PLAYERONE WON";
            Time.timeScale = 0;
        }

        if(res== 2)
        {
            GameObject.Find("Background").GetComponent<AudioSource>().Stop();
            t.text = "" + "RIGHT PLAYERTWO WON";
            Time.timeScale = 0;
        }
	}
}
