using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upperandlowersound : MonoBehaviour {
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ball")
        {
            GetComponent<AudioSource>().Play();
        }
        
    }


   
}
