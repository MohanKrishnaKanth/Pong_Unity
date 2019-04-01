using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    float vlimit;
    bool a = false;
    bool b = false;
    Targetmenu t;
   
    // Use this for initialization
    void Start()
    {
        t = GameObject.Find("Targetmenu").GetComponent<Targetmenu>();
        vlimit = Camera.main.orthographicSize/2;
        
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1 && t.s==true)
        {
            Vector2 touchpos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos))
                {
                    a = true;
                }

            }

            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos) && a == true)
                {
                    transform.position = touchpos;
                }
            }
        }


        if (Input.touchCount > 1 && t.s==true)
        {
            Vector2 touchpos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos))
                {
                    a = true;
                }

            }

            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchpos) && a == true)
                {
                    transform.position = touchpos;
                }
            }

            Vector2 touchposs = Camera.main.ScreenToWorldPoint(Input.GetTouch(1).position);
            if (Input.GetTouch(1).phase == TouchPhase.Began)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchposs))
                {
                    b = true;
                }

            }

            if (Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchposs) && b == true)
                {
                    transform.position = touchposs;
                }
            }
        }

        float y = Mathf.Clamp(transform.position.y, -vlimit, vlimit);
        transform.position=new Vector2(transform.position.x,y);
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GetComponent<AudioSource>().Play();
        }
    }

}
