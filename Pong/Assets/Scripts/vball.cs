using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vball : MonoBehaviour {
    bool h = true;
    bool i = false;
    private void Start()
    {
       
     
    }
   

    private void Update()
    {
        h = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>().v;
        if (transform.position.x>=8.5f||transform.position.x<=-8.5f || transform.position.y >= 4 || transform.position.y <= -4)
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }

        else if(transform.position.x<8.5f || transform.position.y < 4)
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        }

        if(h==false && i==false)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), Random.Range(-100, 100)) * 12);
            i = true;
        }



    }
}
