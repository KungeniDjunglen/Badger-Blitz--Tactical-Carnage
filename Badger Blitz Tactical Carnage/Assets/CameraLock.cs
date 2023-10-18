using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    private new Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        var lookAtPos = Input.mousePosition;
        lookAtPos.z = transform.position.z - camera.transform.position.z;
        lookAtPos = camera.ScreenToWorldPoint(lookAtPos);
        transform.up = lookAtPos - transform.position;
    }
}
