using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public GameObject sunOne;
    public GameObject sunTwo;
    public GameObject sunThree;
    public GameObject sunFour;
    public GameObject sunFive;
    public GameObject sunSix;
    void Start() {
        if(PlayerPrefs.GetInt("Time") == 1){
            sunOne.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 2){
            sunTwo.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 3){
            sunThree.SetActive(true);
        }else if(PlayerPrefs.GetInt("Time") == 4){
            sunFour.SetActive(true);
        }else if(PlayerPrefs.GetInt("Time") == 5){
            sunFive.SetActive(true);
        }
    }
}
