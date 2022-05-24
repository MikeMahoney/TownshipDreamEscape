using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    void Start() {
        if(!PlayerPrefs.HasKey("Time")){
            PlayerPrefs.SetInt("Time", 1);
        } else {
            PlayerPrefs.SetInt("Time", PlayerPrefs.GetInt("Time") + 1);

            this.UpdateObjectives();
        }
    }

    void UpdateObjectives() {
        if(PlayerPrefs.GetString("TapeItem") == "SET" && PlayerPrefs.GetString("GUNMAN") != "SUCCESS"){
            PlayerPrefs.SetString("GUNMAN", "SUCCESS");
        }
        if(PlayerPrefs.GetString("MojitoShopItem") == "SET" && PlayerPrefs.GetString("WATERMAN") != "SUCCESS"){
            PlayerPrefs.SetString("WATERMAN", "SUCCESS");
        }
        if(
            PlayerPrefs.GetString("SPRINKLER") == "ACTIVE" &&
            PlayerPrefs.GetString("SeedsShopItem") == "SET"
        ){
            PlayerPrefs.SetString("FlowerItem", "SET");
        }
    }
}
