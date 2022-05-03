using UnityEngine;

public class LevelCreator : MonoBehaviour
{

    public Texture2D levelMap;
    public ColorToPrefab[] colorMappings;

    // Start is called before the first frame update
    void Start()
    {
        CreateLevel();
    }

    /**
     * This function goes through each pixel on the map image I created 
     */

    void CreateLevel()
    {
        for (int i = 0; i < levelMap.width; i++) //loops through each pixel on the width of the level map
        {
            for (int j = 0; j < levelMap.height; j++) //loops through each pixel on the height of the image
            {
                CreateTile(i, j);
            }
        }
    }

    /*
     * This function creates tiles on my levels based on the colours in the pixel image
     */

    void CreateTile(int i, int j)
    {
        Color pixelColor = levelMap.GetPixel(i, j);

        if (pixelColor.a == 0) // if the pixel colour is transparent just ignore it 
        {
            return;
        }

        foreach (ColorToPrefab colourMapping in colorMappings)
        {
            if (colourMapping.color.Equals(pixelColor))
            {
                Vector2 position = new Vector2(i, j);
                Instantiate(colourMapping.prefab,position, Quaternion.identity, transform);
            }
        }
    }
}

