using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerControl : MonoBehaviour
{
    [SerializeField] public GameObject sprinkler;
    public void ActivateSprinkler() {
        if(
            PlayerPrefs.GetString("WATERMAN") == "SUCCESS" &&
            !sprinkler.GetComponent<ParticleSystem>().isPlaying
        ){
            PlayerPrefs.SetString("SPRINKLER", "ACTIVE");
        } else if(
            PlayerPrefs.GetString("SPRINKLER") == "ACTIVE" &&
            sprinkler.GetComponent<ParticleSystem>().isPlaying
        ){
            PlayerPrefs.SetString("SPRINKLER", "INACTIVE");
        }
    }
}
