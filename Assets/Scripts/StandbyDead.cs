using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StandbyDead : MonoBehaviour
{
    void Start()
    {
        if(PlayerPrefs.GetString("KILLHENWEN") == "SUCCESS"){
            gameObject.SetActive(true);
        }
        Invoke("HideStandby", 2);
    }
    void HideStandby()
    {
        gameObject.SetActive(false);
    }
}
