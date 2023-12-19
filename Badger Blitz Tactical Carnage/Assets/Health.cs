using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public float health;
    public bool IsBoss = false;
    private PlayerMovement playerMovement;
    public TMP_Text text;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        button.onClick.AddListener(ButtonPresser);

    }

    public void TakeDamage(float damage){
        health = health - damage;
        if (health <= 0){
            if(IsBoss){
                playerMovement.enabled = !playerMovement.enabled;
                text.text = "Du vann";
                Debug.Log("Du vann");
                button.gameObject.SetActive(true);
                Cursor.lockState = CursorLockMode.None;

            }
            Destroy(gameObject);

        }
    }
    private void ButtonPresser(){
        SceneManager.LoadScene("MainMenus");
    }
}
