using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Short : MonoBehaviour {

    [SerializeField] GameObject bullet;
    [SerializeField] Bullet bulletScript;
    public float speed;//弾速

    [SerializeField] GameObject camera;
    [SerializeField] CameraRotation rotation;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            /*
            var rotY = 0f;
            var rotZ = 0f;
            if (rotation.rotY >= 180)
            {
                rotY = -rotation.rotY + 360;
            }else 
            {
                rotY = -rotation.rotY;
            }
            var vec3 = new Vector3(rotY, rotation.rotX, 0);
            */
            var vec3 = camera.transform.forward;
            var tama = Instantiate(bullet, transform.position + vec3, camera.transform.rotation);
            tama.GetComponent<Rigidbody>().velocity = vec3 * speed;
            Debug.Log(tama.GetComponent<Rigidbody>().velocity);
        }
        
    }

}
