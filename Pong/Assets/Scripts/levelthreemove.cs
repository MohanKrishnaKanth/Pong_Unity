using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelthreemove : MonoBehaviour {
    public Color[] colors;
    SpriteRenderer sp;
    Rigidbody2D r;
    float v = 0;
    // Use this for initialization
    void Start () {
        sp = GetComponent<SpriteRenderer>();
        r = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(new Vector3(0,0,v));
        v+=4*Time.time*0.05f;
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "upperborder" || collision.gameObject.tag == "Ball" || collision.gameObject.tag == "lowerborder")
        {
            change();
        }

    }
    private void FixedUpdate()
    {
        r.velocity = r.velocity.normalized * 25;
    }

    
    void change()
    {

        {
            int i = Random.Range(0, colors.Length);
            sp.color = colors[i];
        }

    }
}
