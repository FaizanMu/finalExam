/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liveCounting : MonoBehaviour
{
   // public Button healthbutton;
    public Text IncreaseLives;

    public int liveCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial text to display the current count
        IncreaseLives.text = liveCount.ToString();
    }

    // This method is called when the button is clicked
    public void addLives()
    {
        // Increase the count by one and update the text
        liveCount++;
        IncreaseLives.text = liveCount.ToString();
    }
    public void decreaseLives()
    {
        // Increase the count by one and update the text
        liveCount--;
        IncreaseLives.text = liveCount.ToString();
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveCounting : MonoBehaviour
{
   // public Button healthbutton;
    public Text IncreaseLives;

    public int liveCount;

    // Start is called before the first frame update
    void Start()
    {
        liveCount = 0;
        liveCount = PlayerPrefs.GetInt("selectedValue", -1);

        if (liveCount != -1)
    {
        IncreaseLives.text = liveCount.ToString();
    }
        // Set the initial text to display the current count
      //  IncreaseLives.text = liveCount.ToString();
    }

    // This method is called when the button is clicked
    public void addLives()
    {
        // Increase the count by one and update the text
        liveCount++;
        IncreaseLives.text = liveCount.ToString();
    }
    public void decreaseLives()
    {
        // Increase the count by one and update the text
        liveCount--;
        IncreaseLives.text = liveCount.ToString();
    }
}