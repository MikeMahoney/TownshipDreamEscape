using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    void Update()
    {
        if (!PlayerPrefs.HasKey("Money")) {
            PlayerPrefs.SetInt("Money", 0);
        }
        // PlayerPrefs.SetInt("Money", 200);
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Money") + "u";
    }
}
