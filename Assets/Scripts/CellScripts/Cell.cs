using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] public GameObject glass;
    [SerializeField] public GameObject henwen;
    [SerializeField] public GameObject henwenDead;

    void Start() {
        PlayerPrefs.DeleteKey("PosX");
        PlayerPrefs.DeleteKey("PosY");
        PlayerPrefs.DeleteKey("PosZ");
        // PlayerPrefs.SetString("KILLHENWEN", "SUCCESS");
        if(!PlayerPrefs.HasKey("Time")){
            PlayerPrefs.SetInt("Time", 1);
        } else {
            PlayerPrefs.SetInt("Time", PlayerPrefs.GetInt("Time") + 1);

            this.UpdateObjectives();
        }

        if(PlayerPrefs.GetString("KILLHENWEN") == "SUCCESS"){
            glass.SetActive(false);
            henwen.SetActive(false);
            henwenDead.SetActive(true);
        }

        PlayerPrefs.SetString("KILLHENWEN", "STARTED");
    }

    void UpdateObjectives() {
        if(PlayerPrefs.GetString("TapeItem") == "SET" && PlayerPrefs.GetString("GUNMAN") != "SUCCESS"){
            PlayerPrefs.SetString("GUNMAN", "SUCCESS");
        }

        if(PlayerPrefs.GetString("MojitoShopItem") == "SET" && PlayerPrefs.GetString("WATERMAN") != "SUCCESS"){
            PlayerPrefs.SetString("WATERMAN", "SUCCESS");
        }

        if(
            PlayerPrefs.GetString("InvitationItem") == "SET" &&
            PlayerPrefs.GetString("BANDWOMAN") != "SUCCESS" &&
            PlayerPrefs.GetString("HOMELESSCAT") == "SUCCESS" &&
            PlayerPrefs.GetInt("Time") < 7
        ){
            PlayerPrefs.SetString("BANDWOMAN", "SUCCESS");
        }

        if(
            PlayerPrefs.GetString("SPRINKLER") == "ACTIVE" &&
            PlayerPrefs.GetString("SeedsShopItem") == "SET"
        ){
            PlayerPrefs.SetString("FlowerItem", "SET");
        }

        if((7 - PlayerPrefs.GetInt("Time")) == -1) {
            PlayerPrefs.DeleteAll();
        }
    }
}
