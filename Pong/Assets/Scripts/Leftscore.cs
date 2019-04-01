using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leftscore : MonoBehaviour {

    public static int leftsc = 0;
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "" + leftsc;
	}
}
