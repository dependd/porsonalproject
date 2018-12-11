using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    GameControlor gameControlor;
    [SerializeField] Vector3[] enemyPoints;

    [SerializeField]TextChenge text;
    // Use this for initialization
    void Start () {
		gameControlor = GameObject.Find("GameControler").GetComponent<GameControlor>();
        Up();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Up()
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
        var obj = GameObject.Find("PronamaChan1");
        var mapObj = GameObject.Find("EnemyPoint");
        obj.transform.position = enemyPoints[i];
        mapObj.transform.position = new Vector3(enemyPoints[i].x,90,enemyPoints[i].z);
        if(obj.transform.position.y >= 26)
        {
            text.TextUpdate("相手は自分より高い位置にいるぞ！");
        }
        else
        {
            text.TextUpdate("相手は自分より低い位置にいるぞ！");
        }
        Debug.Log(enemyPoints[i]);
    }
}
