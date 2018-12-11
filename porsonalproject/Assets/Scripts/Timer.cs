using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    [SerializeField]GameObject timerObj;
    Text text;
    TextChenge textChenge;

    private float time;
    public int MaxTime;
    public bool countDown = true;
    bool isCatch = true;
	// Use this for initialization
	void Start () {
        text = timerObj.GetComponent<Text>();
        textChenge = timerObj.GetComponent<TextChenge>();
        ChangeTimer();
	}
	
	// Update is called once per frame
	void Update () {
        if (countDown)
        {
            time -= Time.deltaTime;
            if(time < 0)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene("Result");
            }
            var str = time.ToString("F0");
            textChenge.TextUpdate(str);
        }
        else
        {
            if (isCatch)
            {
                GameControlor.Instance.CatchTimer(time, MaxTime);
                isCatch = false;
            }
        }
	}
    private void ChangeTimer()
    {
        switch (GameControlor.Instance.difficulty)
        {
            case GameControlor.Difficulty.easy:
                time = 180;
                MaxTime = (int)time;
                break;
            case GameControlor.Difficulty.hard:
                time = 60;
                MaxTime = (int)time;
                break;
            case GameControlor.Difficulty.normal:
                time = 30;
                MaxTime = (int)time;
                break;
        }
    }
}
