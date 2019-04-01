using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

    public void playgame()
    {
        GameObject.Find("Canvas").transform.Find("menu").transform.Find("PlayButton").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("menu").transform.Find("QuitButton").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("menu").transform.Find("Text").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("level").gameObject.SetActive(true);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
