using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointCounter : MonoBehaviour
{
   // public Button healthbutton;
    public Text IncreasePoints;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial text to display the current count
        IncreasePoints.text = count.ToString();
    }

    // This method is called when the button is clicked
    public void IncrementCount()
    {
        // Increase the count by one and update the text
        count++;
        IncreasePoints.text = count.ToString();
    }
    public void DecrementCount()
    {
        // Increase the count by one and update the text
        count--;
        IncreasePoints.text = count.ToString();
    }
}
