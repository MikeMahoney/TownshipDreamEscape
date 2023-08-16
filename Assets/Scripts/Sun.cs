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
            sunTwo.SetActive(false);
            sunThree.SetActive(false);
            sunFour.SetActive(false);
            sunFive.SetActive(false);
        } else if(PlayerPrefs.GetInt("Time") == 2){
            sunOne.SetActive(false);
            sunTwo.SetActive(true);
            sunThree.SetActive(false);
            sunFour.SetActive(false);
            sunFive.SetActive(false);
        } else if(PlayerPrefs.GetInt("Time") == 3){
            sunOne.SetActive(false);
            sunTwo.SetActive(false);
            sunThree.SetActive(true);
            sunFour.SetActive(false);
            sunFive.SetActive(false);
        }else if(PlayerPrefs.GetInt("Time") == 4){
            sunOne.SetActive(false);
            sunTwo.SetActive(false);
            sunThree.SetActive(false);
            sunFour.SetActive(true);
            sunFive.SetActive(false);
        }else if(PlayerPrefs.GetInt("Time") >= 5){
            sunOne.SetActive(false);
            sunTwo.SetActive(false);
            sunThree.SetActive(false);
            sunFour.SetActive(false);
            sunFive.SetActive(true);
        }
    }
}
