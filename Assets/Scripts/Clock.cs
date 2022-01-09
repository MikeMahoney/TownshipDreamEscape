using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject clockOne;
    public GameObject clockTwo;
    public GameObject clockThree;
    public GameObject clockFour;
    public GameObject clockFive;
    public GameObject clockSix;
    public GameObject clockSeven;
    public GameObject clockEight;
    public GameObject clockNine;
    public GameObject clockTen;
    public GameObject clockEleven;
    void Start() {
        if(!PlayerPrefs.HasKey("Time")){
            PlayerPrefs.SetInt("Time", 1);
        }
        
        if(PlayerPrefs.GetInt("Time") == 1){
            clockOne.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 2){
            clockTwo.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 3){
            clockThree.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 4){
            clockFour.SetActive(true);
         }else if(PlayerPrefs.GetInt("Time") == 5){
            clockFive.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 6){
            clockSix.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 7){
            clockSeven.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 8){
            clockEight.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 9){
            clockNine.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 10){
            clockTen.SetActive(true);
        } else if(PlayerPrefs.GetInt("Time") == 11){
            clockEleven.SetActive(true);
        }
    }
}
