using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Short : MonoBehaviour {

    [SerializeField] GameObject bullet;
    [SerializeField] Bullet bulletScript;
    private const float speed = 10.0f;

    [SerializeField] GameObject camera;
    [SerializeField] CameraRotation rotation;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet,transform.position,Quaternion.identity);
            bulletScript.BulletLotation(rotation.rotX,rotation.rotY);
            Debug.Log(rotation.rotX + rotation.rotY);
        }
        
    }

}
