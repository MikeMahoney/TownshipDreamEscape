using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aerial : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("TapeItem") == "SET" && PlayerPrefs.GetString("GUNMAN") != "SUCCESS"){
            PlayerPrefs.SetString("GUNMAN", "SUCCESS");
        }
    }
}
