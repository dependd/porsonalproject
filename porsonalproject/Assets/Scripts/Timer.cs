using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    [SerializeField]GameObject timerObj;
    Text text;
    TextChenge textChenge;

    [SerializeField]private float time;
    public bool countDown = true;
	// Use this for initialization
	void Start () {
        text = timerObj.GetComponent<Text>();
        textChenge = timerObj.GetComponent<TextChenge>();
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
	}
}
