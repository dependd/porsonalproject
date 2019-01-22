using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour {

    Rigidbody rg;
	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 vector = new Vector3(-transform.forward.x, 1, -transform.forward.z);
            rg.velocity = vector * 20000;
        }
    }
    
}
