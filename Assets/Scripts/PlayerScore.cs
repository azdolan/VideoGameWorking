using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        Debug.Log("Text: " + scoreText.text);

        scoreText.text = "Score: " + score;

    }

    
    public void increasePlayerScore(int value)
    {
        score += value;
        Debug.Log("Increased score to " + score);
        
        
    }

    void Update()
    {
        // Debug.Log("Player Score: " + score);

        // scoreText = GetComponent<Text>();
        //scoreText.text = "Score: " + score; 
    }
}
