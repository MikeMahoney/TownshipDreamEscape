using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkTray : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("MojitoShopItem") == "SET" && PlayerPrefs.GetString("WATERMAN") != "SUCCESS"){
            PlayerPrefs.SetString("WATERMAN", "SUCCESS");
        } else if(
            PlayerPrefs.GetString("OldFashionedShopItem") == "SET" ||
            PlayerPrefs.GetString("MargaritaShopItem") == "SET"
        ) {
            PlayerPrefs.SetString("WATERMAN", "FAILED");
        }
    }
}
