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
        text.TextUpdate(a + "Point!!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private int TimeToPoint()
    {
        int i = (int)(GameControlor.Instance.time) * (7 - GameControlor.Instance.Maxtime / 30);
        Debug.Log(GameControlor.Instance.time + " * " + ("7 - " + GameControlor.Instance.Maxtime + " / 30" ));
        switch (GameControlor.Instance.hitPos)
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
            default:
                i = 0;
                break;
        }
        Debug.Log(i);
        return i;
    }
}
