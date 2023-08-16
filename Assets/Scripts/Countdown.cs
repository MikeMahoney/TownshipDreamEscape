using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public Text countdownText;

    void Start() {
        int newValue = 7 - PlayerPrefs.GetInt("Time");
        countdownText.text = newValue.ToString();
    }
}
