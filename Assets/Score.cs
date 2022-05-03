using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>(); 
        Debug.Log("Text: " + scoreText.text);

        scoreText.text = "Score: " + score; //creates the score text and sets its initial value to 0

    }

    void Update()
    {       
        scoreText.text = "Score: " + score; //changes the score text every time its updated 
    }
}
