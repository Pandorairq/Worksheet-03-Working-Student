using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float sensivityX = 2.0f;
    [SerializeField] private float sensivityY = 2.0f;

    private Transform cameraTransform;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        
        cameraTransform.eulerAngles += new Vector3(- Input.GetAxis("Mouse Y") * sensivityY,
            Input.GetAxis("Mouse X") * sensivityX,
            0.0f);
        PrimitivesCounting.CountPrimitives();
        
    }
}
