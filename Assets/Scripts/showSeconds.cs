/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showSeconds : MonoBehaviour
{
    public static float getSeconds;  
    // Update is called once per frame
    void Update()
    {
       getSeconds = SecondTimer.seconds;
       ShowingSeconds.text = getSeconds.ToString("f2"); // float with two decimals

    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showSeconds : MonoBehaviour
{
    public static float getSeconds;
    public Text countdownText;
    private float countdownTimer;

    void Start()
    {
        countdownTimer = SecondTimer.seconds;
    }

    void Update()
    {
        // Update the countdown timer
        countdownTimer -= Time.deltaTime;

        // Update the countdown text
        countdownText.text = countdownTimer.ToString("f2");

        // Check if the countdown has reached zero
        if (countdownTimer <= 0)
        {
            countdownTimer = 0;
            // Perform any action you want after the countdown reaches zero
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
