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
        float i = (GameControlor.Instance.Maxtime-(GameControlor.Instance.Maxtime - GameControlor.Instance.time)) * 100;
        switch (GameControlor.Instance.difficulty)
        {
            case GameControlor.Difficulty.easy:
                break;
            case GameControlor.Difficulty.hard:
                i = i * 3;
                break;
            case GameControlor.Difficulty.normal:
                i = i * 6;
                break;
        }
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
        switch (GameControlor.Instance.difficulty)
        {
            case GameControlor.Difficulty.easy:
                Debug.Log("難易度ボーナスが" + 2 + "倍つきます");
                i = i * 2;
                break;
            case GameControlor.Difficulty.normal:
                Debug.Log("難易度ボーナスが" + 2.5 + "倍つきます");
                i = i * 2.5f;
                break;
            case GameControlor.Difficulty.hard:
                Debug.Log("難易度ボーナスが" + 3 + "倍つきます");
                i = i * 3;
                break;

        }
        int a = (int)Mathf.Floor(i);
        Debug.Log("結果 = " + a);
        return a;
    }
}
