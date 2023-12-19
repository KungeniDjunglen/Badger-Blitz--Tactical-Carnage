using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public float health;
    public bool IsBoss = false;
    private PlayerMovement playerMovement;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            if(IsBoss){
                playerMovement.enabled = !playerMovement.enabled;
                text.text = "Du vann";
                Debug.Log("Du vann");
            }
            Destroy(gameObject);

        }
    }
}
