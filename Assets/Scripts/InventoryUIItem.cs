using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{

    void Update() {
        if (PlayerPrefs.HasKey(gameObject.name) && PlayerPrefs.GetInt(gameObject.name) == 1) {
            gameObject.SetActive(true);
        }
    }
}
