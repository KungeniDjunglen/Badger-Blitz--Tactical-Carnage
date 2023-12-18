using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;
    public TMP_Text text;
    private PlayerMovement playerMovement;
    public Button button;
    void Start() {
        text.text = "";
        playerMovement = GetComponent<PlayerMovement>();
        button = FindObjectOfType<Button>();
        button.enabled = !button.enabled;
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
        playerMovement.enabled = !playerMovement.enabled;
        Cursor.lockState = CursorLockMode.None;

    }
}
