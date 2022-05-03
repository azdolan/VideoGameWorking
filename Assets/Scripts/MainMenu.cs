using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*
     * This function will load the game from the beginning when the player clicks on the start game button
     */

    public void PlayGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("Currently Active Screen: " + currentScene.name);

        // TODO: build index
        // https://youtu.be/zc8ac_qUXQY?t=557
        SceneManager.LoadScene(currentScene.buildIndex + 1);

        // TODO: This is hardcoded to a level to load, replace with commented out
        // code above when build index is created
        // SceneManager.LoadScene("SceneName");
    }

    /*
     * this function will quit the game when the player 
     */
    public void quitGame()
    {
        Debug.Log("this is a test to see if it works"); //debug log to test that it works
        Application.Quit();
    }
}
