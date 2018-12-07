using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {
    int score;
    [SerializeField]TextChenge text;
	// Use this for initialization
	void Start () {
        score = TimeToPoint();
        string a = score.ToString();
        text.TextUpdate(a);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private int TimeToPoint()
    {
        int i = (int)(GameManager.Instance.time) * 10;
        switch (GameManager.Instance.hitPos)
        {
            case "Leg":
                i += 50;
                break;
            case "Arm":
                i += 80;
                break;
            case "UpperBody":
                i += 100;
                break;
            case "lowerBody":
                i += 70;
                break;
            case "Head":
                i += 250;
                break;
        }
        Debug.Log(i);
        return i;
    }
}
