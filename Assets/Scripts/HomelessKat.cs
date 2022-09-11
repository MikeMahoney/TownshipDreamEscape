using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessKat : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("FlowerBloomItem") == "SET" && PlayerPrefs.GetString("HOMELESSCAT") != "SUCCESS"){
            PlayerPrefs.SetString("HOMELESSCAT", "SUCCESS");
        }

        if(PlayerPrefs.GetString("BANDWOMAN") == "SUCCESS" && PlayerPrefs.GetString("HOMELESSCAT") == "SUCCESS") {
            gameObject.SetActive(true);
        }
    }
}
