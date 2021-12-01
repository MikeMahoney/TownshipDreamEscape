using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinkler : MonoBehaviour
{
    void Start() {
        if(PlayerPrefs.GetString("WATERMAN") == "SUCCESS" && !gameObject.GetComponent<ParticleSystem>().isPlaying){
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}
