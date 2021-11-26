using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aerial : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("TapeItem") == "SET" && PlayerPrefs.GetString("TapeItem") != "SUCCESS"){
            PlayerPrefs.SetString("GUNMAN", "SUCCESS");
        }
    }
}
