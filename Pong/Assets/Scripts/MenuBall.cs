using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBall : MonoBehaviour {
    Rigidbody2D rb;
    Vector2 v;
	// Use this for initialization
	public void Start () {
        rb = GetComponent<Rigidbody2D>();
        Invoke("goball",0);
        //DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * 31;
    }

  
    public void goball()
    {
        int i = Random.Range(0, 100);
        rb.AddForce(i % 2 == 0 ? (new Vector2(-6, 6) * 150) : (new Vector2(6, 6) * 150));
    }
}
