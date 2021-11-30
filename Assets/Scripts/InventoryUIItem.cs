using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{

    void Update() {
        Debug.Log(gameObject.name);
        Debug.Log(PlayerPrefs.HasKey(gameObject.name));
        Debug.Log(PlayerPrefs.GetInt(gameObject.name));
        if (PlayerPrefs.HasKey(gameObject.name) && PlayerPrefs.GetInt(gameObject.name) == 1) {
            gameObject.SetActive(true);
        }
    }
}
