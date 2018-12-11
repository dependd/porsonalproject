using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour {
    int score;
    [SerializeField]TextChenge text;
    [SerializeField] float[] hitPointPoints = new float[5];
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
        float i = (GameControlor.Instance.Maxtime - GameControlor.Instance.time) * 1000;
        Debug.Log("タイムによるスコア = " + i);
        switch (GameControlor.Instance.hitPos)
        {
            case "Leg":
                i = i * hitPointPoints[4];
                Debug.Log("部位による追加ダメージ = " + hitPointPoints[4] + "倍");
                break;
            case "Arm":
                i = i * hitPointPoints[2];
                Debug.Log("部位による追加ダメージ = " + hitPointPoints[2] + "倍");
                break;
            case "UpperBody":
                i = i * hitPointPoints[3];
                Debug.Log("部位による追加ダメージ = " + hitPointPoints[1] + "倍");
                break;
            case "lowerBody":
                i = i * hitPointPoints[1];
                Debug.Log("部位による追加ダメージ = " + hitPointPoints[3] + "倍");
                break;
            case "Head":
                i = i * hitPointPoints[0];
                Debug.Log("部位による追加ダメージ = " + hitPointPoints[0] + "倍");
                break;
            default:
                i = 0;
                break;
        }
        i = i * 30 / GameControlor.Instance.Maxtime;
        Debug.Log("難易度による差し引き = " + (i = i * 1 / GameControlor.Instance.Maxtime));
        int a = (int)Mathf.Floor(i);
        Debug.Log("結果 = " + a);
        return a;
    }
}
