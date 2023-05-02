using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    public InputField NameInputField; //PlayerName
    public static string myPlayerName;
  //  public Text ShowName;
    
    public void DisplayName()
    {
        myPlayerName = NameInputField.text; // assign input to string
    //    ShowName.text = myPlayerName; //assign string to textbox
    }
    
}
