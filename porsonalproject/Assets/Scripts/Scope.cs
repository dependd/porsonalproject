using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scope : MonoBehaviour {

    [SerializeField]GameObject camera;

    [SerializeField]private float lenge;
    public float maxLenge;
    public float minLenge;
    [SerializeField] RawImage scopeObj;
    [SerializeField] GameObject SR;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ADS(Vector3 vec3)
    {
        scopeObj.color = new Color(1, 1, 1, 1);
        Vector3 vec = SR.transform.position;
        SR.transform.position = new Vector3(1, 1, 1);
        camera.transform.position = camera.transform.position + vec3 * lenge;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0.0f)
        {
            if (lenge <= maxLenge) lenge += 1;
        }else if (scroll < 0.0f)
        {
            if(lenge >= minLenge) lenge -= 1;
        }
    }
}
