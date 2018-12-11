using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlor : SingletonMonoBehaviour<GameControlor> {
    public enum Difficulty
    {
        easy,
        normal,
        hard
    }
    public Difficulty difficulty;

    [HideInInspector] public float time;
    [HideInInspector] public int Maxtime;
    [HideInInspector] public string hitPos;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameController");
        if (objs.Length >= 2) return;
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    public void CatchTimer(float x, int y)
    {
        time = x; Maxtime = y; ;
    }
    public void CatchPos(string pos)
    {
        hitPos = pos;
    }
}
