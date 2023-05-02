using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondTimer : MonoBehaviour
{
    public Slider TimeSlider; // slider is set from 2 to 6 with start value of 4, same as speed in PlayerMovement
    public Text SecondText;

    public static float seconds;   // was flaot chanegd to int

    // Update is called once per frame
    void Update()
    {
        seconds = TimeSlider.value;
        //SecondText.text = seconds.ToString; // float with two decimals
        SecondText.text = seconds.ToString("f2"); // float with two decimals
      // SecondText.text = seconds; // float with two decimals
    }
}
