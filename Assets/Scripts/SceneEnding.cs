using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneEnding : MonoBehaviour
{
    private bool UseLoadingIntermediaryScene = true;
    // Start is called before the first frame update
    public void ExitTheScene()
    {
        SceneManager.LoadScene("3Exit");
        PlayerPrefs.DeleteAll();
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        PlayerPrefs.DeleteAll();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("1Intro");
        PlayerPrefs.DeleteAll();
    }
    public void RestartGaming()
    {
       // SceneManager.LoadScene("1Intro");
       PlayerPrefs.DeleteAll();
       SceneManager.LoadSceneAsync(UseLoadingIntermediaryScene ? "1intro" : "2Game");
    }

}
