using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {

    public int addScore;
    int score;
	// Use this for initialization
	void Start () {
        score += addScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private int TimeToPoint(float time)
    {
        // maxtime
        // mintime
        int i = (int)(time * 0.3f) * 10;


        
        return i;
    }
}
