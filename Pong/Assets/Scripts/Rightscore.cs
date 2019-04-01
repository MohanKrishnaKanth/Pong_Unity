using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rightscore : MonoBehaviour {

    public static int rightscore = 0;
	void Update () {
        GetComponent<Text>().text=""+rightscore;
	}
}
