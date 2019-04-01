using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class borderpoints : MonoBehaviour {
  
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ball")
        {
            Rightscore.rightscore += 1;
            GetComponent<AudioSource>().Play();
        }
    }

}
