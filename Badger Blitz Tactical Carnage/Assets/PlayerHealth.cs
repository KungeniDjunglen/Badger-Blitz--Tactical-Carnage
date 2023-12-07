using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;
    public TMP_Text text;
    void Start() {
        text.text = "";
    }

    public void TakeDamage(float Damage){
        health -= Damage;
        if(health <= 0){
            Die();
        }
    }
    private void Die(){
        //Do the losing 
        Debug.Log("Du dog");
        text.text = "Du dog";
        Destroy(gameObject);
    }
}
