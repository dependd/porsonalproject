using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotSpeed = 3.0f;
    public Transform varRot;
    public Transform horRot;

    public float rotX;
    public float rotY;

    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        varRot = horRot.parent;
        horRot = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");

        rotX += Y_Rotation * rotSpeed;
        rotY -= X_Rotation * rotSpeed;

        rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);
        while (rotY < 0.0f) { rotY += 360.0f; }
        while (rotY > 360.0f) { rotY -= 360.0f; }
        
        horRot.transform.eulerAngles = new Vector3(-rotX, -rotY, 0);
        varRot.transform.eulerAngles = new Vector3(0, -rotY, 0);
    }
}
