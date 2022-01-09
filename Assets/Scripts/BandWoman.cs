using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandWoman : MonoBehaviour
{
    void Update() {
        if(
            PlayerPrefs.GetString("InvitationItem") == "SET" &&
            PlayerPrefs.GetString("BANDWOMAN") != "SUCCESS" &&
            PlayerPrefs.GetInt("Time") < 7
        ){
            PlayerPrefs.SetString("BANDWOMAN", "SUCCESS");
        } else if(PlayerPrefs.GetInt("Time") >= 7) {
            PlayerPrefs.SetString("BANDWOMAN", "FAILED");
        }
    }
}
