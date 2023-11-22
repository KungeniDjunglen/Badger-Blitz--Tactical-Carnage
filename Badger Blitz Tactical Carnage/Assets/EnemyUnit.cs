using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour
{
    public float speed = 10f;
    public Transform Target;
    public float minDistance = 2.5f;

    public float Damage = 5f;
    public float DamageInterval = 1f; //i sekunder
    private float TimeToStrike = 0;
    private PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsNearPlayer()){
            transform.LookAt(Target);

            float distance = Vector3.Distance(transform.position, Target.position);
            if(distance >= minDistance){
                transform.position += transform.forward * speed * Time.deltaTime; 
            }
            if(distance <= minDistance){ //Whitin range
                if(TimeToStrike <= Time.time){
                    TimeToStrike = Time.time + DamageInterval;
                    Debug.Log("Ouch");
                    playerHealth.TakeDamage(Damage);
                }
            }
            
        }
    }
    private bool IsNearPlayer(){
        if((Target.transform.position-this.transform.position).sqrMagnitude<10*10){
            return true;
        }
        else{
            return false;
        }
    }

    
}
