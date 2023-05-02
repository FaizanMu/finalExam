/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class readingScore : MonoBehaviour
{
    public Text HighScores;
    private int num_scores = 10;

public void ShowTopScores()
    {
        string path = "Assets/attribution.txt";
        string line;
        string[] fields;
        string[] playerNames = new string[num_scores];
        int[] playerScores = new int[num_scores];
        int scores_read = 0;

        HighScores.text = ""; // clear the scores box

        StreamReader reader = new StreamReader(path);
        while(!reader.EndOfStream && scores_read < num_scores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }

    }
    public void DeleteAllScores()
    {
        StreamWriter writer = new StreamWriter(path);
        writer.Write("");
        writer.Close();
        HighScores.text = "";
        Debug.Log("Scores deleted");
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class readingScore : MonoBehaviour
{
    public Text HighScores;
    private int num_scores = 10;
    private string path = "Assets/attribution.txt";

    public void ShowTopScores()
    {
        string line;
        string[] fields;
        string[] playerNames = new string[num_scores];
        int[] playerScores = new int[num_scores];
        int scores_read = 0;

        HighScores.text = ""; // clear the scores box

        StreamReader reader = new StreamReader(path);
        while(!reader.EndOfStream && scores_read < num_scores)
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            HighScores.text += fields[0] + " : " + fields[1] + "\n";
            scores_read += 1;
        }
    }

    public void DeleteAllScores()
    {
        // Delete the file if it exists
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        // Clear the high scores display
        HighScores.text = "";
    }

    public void DeleteScores()
{
    string path = Application.persistentDataPath + "/scores.txt";
    StreamWriter writer = new StreamWriter(path);
    writer.Write("");
    writer.Close();
    ShowTopScores();
}

}
