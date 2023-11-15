using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    public float speed = 10f;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(IsNearPlayer()){
            if(Player.transform.X - transform.position.X > 0){
                transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0,0);
            }
            if(Player.transform.X - transform.position.X < 0){
                transform.position = transform.position + new Vector3(-speed*Time.deltaTime, 0,0);
            }
            if(Player.transform.Y - transform.position.Y > 0){
                transform.position = transform.position + new Vector3(speed*Time.deltaTime, 0,0);
            }
            if(Player.transform.Y - transform.position.Y < 0){
                transform.position = transform.position + new Vector3(-speed*Time.deltaTime, 0,0);
            }
        }
    }
    private bool IsNearPlayer(){
        return true;
    }

    
}
