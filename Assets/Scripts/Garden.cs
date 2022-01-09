using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garden : MonoBehaviour
{
    [SerializeField] public GameObject plantedSeed;
    [SerializeField] public GameObject plantedFlower;
    void Start() {
        if(
            PlayerPrefs.GetString("SPRINKLER") == "ACTIVE" &&
            PlayerPrefs.GetString("SeedsShopItem") == "SET" &&
            PlayerPrefs.GetString("FlowerItem") == "SET"
        ){
            plantedFlower.SetActive(true);
            plantedSeed.SetActive(false);
        }
    }
}
