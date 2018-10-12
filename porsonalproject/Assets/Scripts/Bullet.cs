using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBullet();
	}

    void MoveBullet()
    {
        this.transform.position += new Vector3(0,0,1);
    }
}
