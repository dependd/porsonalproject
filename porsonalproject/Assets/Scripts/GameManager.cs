using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    GameControlor gameControlor;
    [SerializeField] GameObject[] enemyObjs; 
    // Use this for initialization
    void Start () {
		gameControlor = GameObject.Find("GameManager").GetComponent<GameControlor>();
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
        enemyObjs[i].SetActive(true);
    }
}
