using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public int LevelLoad;
    public string levelToLoad;


    public bool loadLevelWithInt = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;
        Debug.Log("Player collided: " + collisionGameObject.name);

        if(collisionGameObject.name == "Player")
        {
            LoadScene();
            Debug.Log("Level loaded");
        }
    }
    void LoadScene()
    {
        if (loadLevelWithInt == true)
        {
            SceneManager.LoadScene(LevelLoad);
            Debug.Log("Loading level: " + LevelLoad);

        }
        else
        {
            SceneManager.LoadScene(levelToLoad);
            Debug.Log("Loading level: " + levelToLoad);
        }
    }
}
