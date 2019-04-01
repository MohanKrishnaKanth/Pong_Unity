using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftplayerborder : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= -7.5f)
        {
            transform.position = new Vector2(-7.5f, transform.position.y);
        }

        if (transform.position.x >= -1.5f)
        {
            transform.position = new Vector2(-1.5f, transform.position.y);
        }
    }
}
