using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Television : MonoBehaviour
{
    public GameObject TVScreen;

    void Start() {
        if (PlayerPrefs.GetString("TapeItem") == "SET") {
            TVScreen.SetActive(true);
        }
    }
}
