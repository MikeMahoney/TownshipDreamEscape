using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Standby : MonoBehaviour
{
    void Start()
    {
        if(PlayerPrefs.HasKey("PosX")){
            gameObject.SetActive(false);
        } else {
            Invoke("HideStandby", 2);
        }
    }
    void HideStandby()
    {
        gameObject.SetActive(false);
    }
}
