using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    GameControlor controlor;
	// Use this for initialization
	void Start () {
        controlor = GameObject.Find("GameManager").GetComponent<GameControlor>();
	}
	
    public void Easy()
    {
        controlor.difficulty = GameControlor.Difficulty.easy;
        SceneManager.LoadScene("Game");
    }
    public void Normal()
    {
        controlor.difficulty = GameControlor.Difficulty.normal;
        SceneManager.LoadScene("Game");
    }
    public void Hard()
    {
        controlor.difficulty = GameControlor.Difficulty.hard;
        SceneManager.LoadScene("Game");
    }
}
