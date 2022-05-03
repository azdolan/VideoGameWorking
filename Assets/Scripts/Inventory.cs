using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Text keyText;
    public static int keyCount = 0;

    void Start()
    {
        keyCount = 0;
        keyText = GetComponent<Text>();
        keyText.text = "Keys : " + keyCount; //creates the key text and sets it to 0
    }

    private void Update()
    {
        keyText.text = "Keys : " + keyCount;//updates the key text
    }

    public void keyFound(int increase)
    {
        keyCount += increase;//increases the keycount by an amount 
    }
}
