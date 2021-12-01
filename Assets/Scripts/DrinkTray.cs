using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkTray : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("MojitoShopItem") == "SET" && PlayerPrefs.GetString("WATERMAN") != "SUCCESS"){
            PlayerPrefs.SetString("WATERMAN", "SUCCESS");
        }
    }
}
