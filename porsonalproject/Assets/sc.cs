using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour {
    Rigidbody rg;
	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody>();
        Move();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Move()
    {
        rg.AddForce(new Vector3(300, 2000, 300), ForceMode.Impulse);
    }
}
