using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkTray : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("MojitoShopItem") == "SET" && PlayerPrefs.GetString("MojitoShopItem") != "SUCCESS"){
            PlayerPrefs.SetString("WATERMAN", "SUCCESS");
        }
    }
}
