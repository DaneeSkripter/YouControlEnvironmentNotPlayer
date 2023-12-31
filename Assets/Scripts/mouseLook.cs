using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float sensitivity = 200f;
    private float xRotation = 0f;
    public Transform playerBody;
    
    private void FixedUpdate()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= y;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * x);
        }
    }
}
