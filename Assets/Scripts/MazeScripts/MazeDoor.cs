using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeDoor : MonoBehaviour
{
    public GameObject appleLight;
    public GameObject bananaLight;
    public GameObject greenLight;
    public GameObject grapesLight;
    void Update() {
        if(
            PlayerPrefs.GetString("APPLE") == "SUCCESS" &&
            PlayerPrefs.GetString("GREEN") == "SUCCESS" &&
            PlayerPrefs.GetString("BANANA") == "SUCCESS" &&
            PlayerPrefs.GetString("GRAPES") == "SUCCESS"
        ){
            gameObject.SetActive(false);
        }

        if(
            PlayerPrefs.GetString("APPLE") == "SUCCESS"
        ){
            appleLight.SetActive(true);
        }

        if(
            PlayerPrefs.GetString("BANANA") == "SUCCESS"
        ){
            bananaLight.SetActive(true);
        }
        if(
            PlayerPrefs.GetString("GREEN") == "SUCCESS"
        ){
            greenLight.SetActive(true);
        }
        if(
            PlayerPrefs.GetString("GRAPES") == "SUCCESS"
        ){
            grapesLight.SetActive(true);
        }

    }
}
