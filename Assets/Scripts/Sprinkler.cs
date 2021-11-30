using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinkler : MonoBehaviour
{
    void Update() {
        Debug.Log(gameObject.GetComponent<ParticleSystem>().isPlaying);
        if(PlayerPrefs.GetString("WATERMAN") == "SUCCESS" && !gameObject.GetComponent<ParticleSystem>().isPlaying){
            gameObject.GetComponent<ParticleSystem>().Play();
        }
    }
}
