using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropDown : MonoBehaviour
{
    public Dropdown liveDrop;
    // Start is called before the first frame update
    void Start()
{
    // Load the previously selected dropdown value (if any)
    int selectedValue = PlayerPrefs.GetInt("selectedValue", -1);
    if (selectedValue != -1)
    {
        liveDrop.value = selectedValue;
    }
}

public void OnDropdownValueChanged()
{
    // Store the selected dropdown value
    PlayerPrefs.SetInt("selectedValue", liveDrop.value);
}
}
