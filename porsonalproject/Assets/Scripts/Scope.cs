using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scope : MonoBehaviour {

    [SerializeField]GameObject camera;

    public float lenge;
    public float maxLenge;
    public float minLenge;
    [SerializeField] RawImage scopeObj;
    [SerializeField] GameObject SR;
    Vector3 fastPos;
    Vector3 basePos;
    bool Scoping = false;
    // Use this for initialization
    void Start()
    {
        fastPos = transform.position;
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void FixedUpdate()
    {
        /*
        //rayの作成
        Vector3 pos = transform.position;
        Ray ray = new Ray(fastPos, pos - fastPos);
        Ray ray2 = new Ray(basePos, pos);
        //rayが当たったオブジェクトの情報を入れる箱
        RaycastHit hit;
        //rayの飛ばせる距離
        int distance = 5;
        //rayの可視化
        Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);
        //もしrayがオブジェクトに衝突したら
        if (Physics.Raycast(ray2,out hit,distance))
        {
            transform.position = basePos;
        }
        else
        {
            if (Physics.Raycast(ray, out hit, distance))
            {
                transform.position = fastPos;
                Scoping = true;
            }
            else
            {
                fastPos = pos;
                Scoping = false;
            }
        }*/
    }
    public void ADS(Vector3 vec3)
    {
        scopeObj.color = new Color(1, 1, 1, 1);
        SR.SetActive(false);
        //camera.transform.position = camera.transform.position + vec3 * lenge;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0.0f)
        {
            if (Scoping) return;
            //if (lenge <= maxLenge) lenge += 1;
            if(Camera.main.fieldOfView > minLenge)Camera.main.fieldOfView -= 1;
        }else if (scroll < 0.0f)
        {
            //if(lenge >= minLenge) lenge -= 1;40
            if (Camera.main.fieldOfView < maxLenge) Camera.main.fieldOfView += 1;
        }
    }
}
