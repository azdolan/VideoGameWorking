using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScreen : MonoBehaviour
{

    public GameObject gameOverMenu;

    private void Update()
    {
        quitGame();
    }

    // OnEnable and OnDisable allow us to safely subscribe to a public event
    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void Setup()
    {
        gameObject.SetActive(true);
    }


    public void EnableGameOverMenu()
    {
        
        gameOverMenu = GameObject.Find("GameOver");
        
        Debug.Log("Enabling Menu");
        gameOverMenu.SetActive(true);
    }


    public void restartLevel()
    {

        Debug.Log("Restarting Level " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("Quitting");
        }
    }
    
}
