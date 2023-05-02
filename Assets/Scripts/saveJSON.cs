using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class saveJSON : MonoBehaviour
{
    [SerializeField] private string fileName = "save.json";
    
    public void SaveGame()
    {
        // Create a new JSON object to hold game state
        GameState gameState = new GameState();
        
        // Set game state properties here...
        gameState.playerHealth = 100;
        gameState.playerPosition = new Vector3(0, 0, 0);
        
        // Serialize the game state to JSON
        string json = JsonUtility.ToJson(gameState);
        
        // Write the JSON data to a file
        string filePath = Path.Combine(Application.persistentDataPath, fileName);
        File.WriteAllText(filePath, json);
        
        Debug.Log("Game saved to: " + filePath);
    }
}

[System.Serializable]
public class GameState
{
    public int playerHealth;
    public Vector3 playerPosition;
    // Add any other game state properties here...
}
