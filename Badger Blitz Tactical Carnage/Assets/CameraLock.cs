using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    private new Camera camera;
    public Transform target;
    private Vector3 offset = new Vector3(0, 5, -15);
    private float smoothTime = 0.25f;
    private Vector3 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void LateUpdate() 
    {
        float change = Input.GetAxis("Mouse Y");
        transform.Rotate(-change,0,0);
        
    }
}