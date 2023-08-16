using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessKatClub : MonoBehaviour
{
    void Update() {
        if(PlayerPrefs.GetString("BANDWOMAN") == "SUCCESS" && PlayerPrefs.GetString("HOMELESSCAT") == "SUCCESS") {
            gameObject.SetActive(true);
        }
    }
}
