using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    Rigidbody2D rb;
    public float speed;
    public bool sb = false;
    public bool v = true;
    GameObject [] gameobj;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        sb = GameObject.Find("Targetmenu").GetComponent<Targetmenu>().s;
        if (sb == true )
        {
           startball();
        }

      if(transform.position.y>=5.7f||transform.position.y<=-5.7f)
        {
            Destroy(gameObject);
        }
        gameobj = GameObject.FindGameObjectsWithTag("vball");
        
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * 21;
    }

    void startball()
    {
        if(v==true)
        {
            Invoke("goball", 2f);
            v = false;
        }

    }
        void goball()
        {
            int i = Random.Range(0, 100);
            rb.AddForce(i % 2 == 0 ? (new Vector2(-6, 0) * 150) : (new Vector2(6, 0) * 150));
            v = false;
        }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Leftplayer")
        {
            float dis = transform.position.y - GameObject.FindGameObjectWithTag("Leftplayer").transform.position.y;
            rb.velocity = new Vector2(5f, dis)*speed;
        }

        else if (collision.gameObject.tag == "Rightplayer")
        {
            float dis = transform.position.y - GameObject.FindGameObjectWithTag("Rightplayer").transform.position.y;
            rb.velocity = new Vector2(-5f, dis)*speed;
        }

        else if (collision.gameObject.tag == "sideborder")
        {
            Destroy(gameObject);
            bye();
        }

    }
    void bye()
    {
        foreach(GameObject vball in gameobj)
        {
            GameObject.Destroy(vball);
        }
    }


}
