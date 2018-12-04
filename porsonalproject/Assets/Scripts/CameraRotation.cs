using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRotation : MonoBehaviour
{
    public float rotSpeed = 3.0f;
    public float ADSSpeed = 1.5f;
    public Transform varRot;
    public Transform horRot;

    float rot = 0;
    public float rotX;
    public float rotY;

    Scope scope;
    [SerializeField] RawImage scopeObj;
    [SerializeField] GameObject SR;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        varRot = GameObject.Find("Player").transform;
        horRot = GetComponent<Transform>();
        scope = GetComponent<Scope>();
    }

    // Update is called once per frame
    void Update()
    {
        horRot.position = varRot.transform.position;
        horRot.position += new Vector3(0,1,0);

        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        
        rotX += Y_Rotation * rot;
        rotY -= X_Rotation * rot;

        rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);
        while (rotY < 0.0f) { rotY += 360.0f; }
        while (rotY > 360.0f) { rotY -= 360.0f; }
        
        horRot.transform.eulerAngles = new Vector3(-rotX, -rotY, 0);
        varRot.transform.eulerAngles = new Vector3(0, -rotY, 0);

        if (Input.GetMouseButton(1))
        {
            rot = ADSSpeed;
            scope.ADS(this.transform.forward);
        }
        else
        {
            rot = rotSpeed;
            scopeObj.color = new Color(1, 1, 1, 0);
            SR.SetActive(true);
        }
    }
}
