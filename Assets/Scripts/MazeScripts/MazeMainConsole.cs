using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMainConsole : MonoBehaviour
{
    [SerializeField] public GameObject particleLeft;
    [SerializeField] public GameObject particleRight;
    public void SetMainConsoleSuccess() {
        PlayerPrefs.SetString("SHIP_CONTROL", "ACTIVE");
    }

    void Update() {
        Debug.Log(PlayerPrefs.GetString("SHIP_CONTROL"));
        Debug.Log(particleLeft.GetComponent<ParticleSystem>().isPlaying);
        if (
            PlayerPrefs.GetString("SHIP_CONTROL") == "ACTIVE" &&
            !particleLeft.GetComponent<ParticleSystem>().isPlaying &&
            !particleRight.GetComponent<ParticleSystem>().isPlaying
        ) {
            particleLeft.GetComponent<ParticleSystem>().Play();
            particleRight.GetComponent<ParticleSystem>().Play();
        } else if(PlayerPrefs.GetString("SHIP_CONTROL") != "ACTIVE") {
            particleLeft.GetComponent<ParticleSystem>().Stop();
            particleRight.GetComponent<ParticleSystem>().Stop();
        }
    }
}
