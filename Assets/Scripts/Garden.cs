using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garden : MonoBehaviour
{
    [SerializeField] public GameObject plantedSeed;
    [SerializeField] public GameObject plantedFlower;
    void Update() {
        if(PlayerPrefs.GetString("WATERMAN") == "SUCCESS" && !plantedFlower.activeSelf){
            plantedFlower.SetActive(true);
            plantedSeed.SetActive(false);
        }
    }
}
