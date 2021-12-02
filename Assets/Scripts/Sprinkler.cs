using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinkler : MonoBehaviour
{
    void Update() {
        if(
            PlayerPrefs.GetString("SPRINKLER") == "ACTIVE" &&
            !gameObject.GetComponent<ParticleSystem>().isPlaying
        ){
            gameObject.GetComponent<ParticleSystem>().Play();
        } else if(
            PlayerPrefs.GetString("SPRINKLER") == "INACTIVE" &&
            gameObject.GetComponent<ParticleSystem>().isPlaying
        ) {
            gameObject.GetComponent<ParticleSystem>().Stop();
        }
    }
}
