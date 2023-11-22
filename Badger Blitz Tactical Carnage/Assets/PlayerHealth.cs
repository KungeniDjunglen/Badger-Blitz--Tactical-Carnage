using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;
    
    public void TakeDamage(float Damage){
        health -= Damage;
        if(health <= 0){
            Die();
        }
    }
    private void Die(){
        //Do the losing 
        Debug.Log("Du dog");
    }
}
