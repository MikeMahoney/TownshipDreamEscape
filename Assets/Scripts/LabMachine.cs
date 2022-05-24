using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabMachine : MonoBehaviour
{
    [SerializeField] private GameObject labmanAlive;
    [SerializeField] private GameObject labmanDead;
    [SerializeField] private GameObject labmanSaved;
    [SerializeField] private ParticleSystem tubeOne;
    [SerializeField] private ParticleSystem tubeTwo;

    void Start()
    {
        if(PlayerPrefs.GetString("LABMAN") == "SUCCESS"){
            labmanAlive.SetActive(false);
            labmanSaved.SetActive(true);
        } else if (PlayerPrefs.GetString("LABMAN") == "FAILED") {
            labmanAlive.SetActive(false);
            labmanDead.SetActive(true);
        }
    }

    void Update() {
        if(
            (PlayerPrefs.GetString("LABMAN") == "SUCCESS" || PlayerPrefs.GetString("LABMAN") == "FAILED") &&
            tubeOne.isPlaying &&
            tubeTwo.isPlaying
        ) {
           tubeOne.Stop();
           tubeTwo.Stop();
        }
    }

    public void deactivateMachine() {
        if(PlayerPrefs.GetString("CushionItem") == "SET"){
            labmanAlive.SetActive(false);
            labmanSaved.SetActive(true);
            PlayerPrefs.SetString("LABMAN", "SUCCESS");
        } else {
            labmanAlive.SetActive(false);
            labmanDead.SetActive(true);
            PlayerPrefs.SetString("LABMAN", "FAILED");
        }
    }
}
