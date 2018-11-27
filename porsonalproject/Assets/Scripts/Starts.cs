using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starts : MonoBehaviour {
    [SerializeField] GameObject buttonObj;
    [SerializeField] TextChenge textChenge;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            textChenge.TextUpdate("SELECT DIFFICULTY");
            buttonObj.SetActive(true);
        }
	}
}
