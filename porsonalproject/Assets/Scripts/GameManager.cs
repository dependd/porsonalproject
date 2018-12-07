using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonMonoBehaviour<GameManager> {
    GameControlor gameControlor;
    [SerializeField] Vector3[] enemyPoints;

    [HideInInspector]public float time;
    [HideInInspector] public int Maxtime;
    [HideInInspector] public string hitPos;
    // Use this for initialization
    void Start () {
		gameControlor = GameObject.Find("GameControler").GetComponent<GameControlor>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Up()
    {
        switch (gameControlor.difficulty)
        {
            case GameControlor.Difficulty.easy:
                InstanceEnemy(4);
                break;
            case GameControlor.Difficulty.normal:
                InstanceEnemy(6);
                break;
            case GameControlor.Difficulty.hard:
                InstanceEnemy(10);
                 break;
        }
    }
    private void InstanceEnemy(int max)
    {
        int i = Random.Range(0,max + 1);
        // enemyPoints[i];
    }
    public void CatchTimer(float x,int y)
    {
        time = x;Maxtime = y;;
    }
    public void CatchPos(string pos)
    {
        hitPos = pos;
    }
}
