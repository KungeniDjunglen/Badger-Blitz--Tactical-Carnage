using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        button.gameObject.SetActive(false);
        button.onClick.AddListener(ButtonPresser);
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
        button.gameObject.SetActive(true);

    }
    private void ButtonPresser(){
        SceneManager.LoadScene("MainMenus");
    }
}
