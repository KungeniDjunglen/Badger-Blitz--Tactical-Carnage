using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20f;
    public float JumpHeight = 10f;
    private Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            player.velocity = transform.forward * speed;
        }
        if(Input.GetKey(KeyCode.S)){
            player.velocity = transform.forward * -speed;
        }
        if(Input.GetKey(KeyCode.D)){
            player.velocity = transform.right * speed;
        }
        if(Input.GetKey(KeyCode.A)){
            player.velocity = transform.right * -speed;
        }

        if(Input.GetKey(KeyCode.Space) && player.velocity.y == 0){
            player.AddForce(Vector3.up * JumpHeight, ForceMode.Impulse);
        }

        float change = Input.GetAxis("Mouse X");
        transform.Rotate(0,change,0);
    }
}
