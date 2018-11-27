using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlor : MonoBehaviour {

    public enum Difficulty
    {
        easy,
        normal,
        hard
    }
    private enum Scene
    {
        start,
        game,
        end
    }
    public Difficulty difficulty;
    private Scene scene;

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
}
