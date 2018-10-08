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
            rigidbody.AddForce(new Vector3(0,0,10));

        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.07f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.07f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, 0, -0.07f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(0, 5, 0);
        }
	}
}
