using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Short : MonoBehaviour {

    [SerializeField] GameObject bullet;
    [SerializeField] Bullet bulletScript;
    public float speed;//弾速

    [SerializeField] GameObject camera;
    [SerializeField] CameraRotation rotation;
    bool isShort = true;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (!isShort) return;
        if (Input.GetMouseButtonDown(0))
        {
            var vec3 = camera.transform.forward;
            var tama = Instantiate(bullet, transform.position + vec3 + new Vector3(0, 1, 0), camera.transform.rotation);
            tama.GetComponent<Rigidbody>().velocity = vec3 * speed;
            Debug.Log(tama.GetComponent<Rigidbody>().velocity);
            //isShort = false;
            Timer timer = GameObject.Find("Timer").GetComponent<Timer>();
            timer.countDown = false;
            isShort = false;
        }

    }

}
