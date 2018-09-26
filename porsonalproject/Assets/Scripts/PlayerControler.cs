using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {
    Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0,0,0.07f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 1, 0);
        }
	}
}
