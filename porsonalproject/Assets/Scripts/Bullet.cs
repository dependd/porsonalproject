using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 vec3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBullet();
	}

    void MoveBullet()
    {
        this.transform.position += vec3;
    }

    public void BulletLotation(float x,float y)
    {
        vec3 = new Vector3(x, y, 0);
    }
}
