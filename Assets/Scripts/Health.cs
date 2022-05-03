using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Class to display on screen value of player health
/// </summary>
public class Health : MonoBehaviour
{
    
    public Text healthText;
    public static int currentHealth;
    

    void Start()
    {
        currentHealth = 100;
        healthText = GetComponent<Text>();

        healthText.text = "Health: " + currentHealth;
    }
    
    void Update()
    {

        healthText.text = "Health: " + currentHealth;
    }

}

