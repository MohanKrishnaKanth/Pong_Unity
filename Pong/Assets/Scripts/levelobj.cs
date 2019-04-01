using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelobj : MonoBehaviour {
    public int n = 0;
  
    // Use this for initialization
    public void Start()
    {
        
        DontDestroyOnLoad(gameObject);
    }
    public void one()
    {
        n = 1;
        SceneManager.LoadScene("Main");
    }

    public void two()
    {
        n = 2;
        SceneManager.LoadScene("Main");
    }

    public void three()
    {
        n = 3;
        SceneManager.LoadScene("Main");
    }

    public void four()
    {
        n = 4;
        SceneManager.LoadScene("Main");
    }
}
