using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {
    public Color[] colors;
    SpriteRenderer sp;
    bool a = true;
    
    Vector2 v;
    // Use this for initialization
    void Start () {
        sp = GetComponent<SpriteRenderer>();
        
        v.x = 0;
        v.y = -3;
    }

  
    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
       
            if (  collision.gameObject.tag == "Ball" )
            {
                change();
            }

    }

    private void Update()
    {
        double val = transform.position.y;
       if(a==true)
        {
            transform.Translate(Vector3.down * 2 * Time.deltaTime);
        }

        if (val <= -3 )
        {
            a = false;
        }

        if(a==false)
        {
            transform.Translate(Vector3.up * 2 * Time.deltaTime);
        }

        if (val >= 3)
        {
            a = true;
        }


    }

 


    void change()
    {
        
        {
            int i = Random.Range(0, colors.Length);
            sp.color = colors[i];
        }
       
    }

}
