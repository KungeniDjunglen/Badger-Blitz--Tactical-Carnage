using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossHealth : MonoBehaviour
{
    public float health;
    public TMP_Text text;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            Destroy(gameObject);
            Win();
        }
    }
    private void Win()
    {
        //Do the winning
        text.text = "Du vann";
        playerMovement.enabled = !playerMovement.enabled;
        Cursor.lockState = CursorLockMode.None;
    }
}
