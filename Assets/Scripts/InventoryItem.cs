using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    void Update()
    {
       if(PlayerPrefs.GetInt(gameObject.tag) == 1 || PlayerPrefs.GetInt(gameObject.tag + "TAKEN") == 2){
           gameObject.SetActive(false);
       }
    }
}
