using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandWoman : MonoBehaviour
{
    public AudioSource music;
    public AudioSource fluteMusic;
    public GameObject homelessKat;

    void Start() {
        if(PlayerPrefs.GetString("BANDWOMAN") == "SUCCESS") {
            music.Stop();
            fluteMusic.Play();
        }
    }

    void Update() {
        if(PlayerPrefs.GetInt("Time") >= 7) {
            PlayerPrefs.SetString("BANDWOMAN", "FAILED");
        }

        if(PlayerPrefs.GetString("BANDWOMAN") == "SUCCESS" && PlayerPrefs.GetString("HOMELESSCAT") == "SUCCESS") {
            homelessKat.SetActive(true);
        }
    }
}
