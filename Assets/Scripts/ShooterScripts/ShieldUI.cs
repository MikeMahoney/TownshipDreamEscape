using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUI : MonoBehaviour
{
    public int sequence;
    void Update ()
    {
        if(PlayerPrefs.GetInt("SHIELD_COUNT") < sequence){
            gameObject.SetActive(false);
        }
    }
}