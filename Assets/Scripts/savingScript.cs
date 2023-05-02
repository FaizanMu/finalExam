using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class savingScript : MonoBehaviour
{
    public Button saveButton;

    void Start()
    {
        saveButton.onClick.AddListener(SaveTheGame);
    }

    public void SaveTheGame()
    {
        string savePath = Application.persistentDataPath + "/saved_game.txt";
        StreamWriter writer = new StreamWriter(savePath);
        // Write game data to file using writer
        writer.Close();
        Debug.Log("Save successful");
    }
}
