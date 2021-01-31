using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    void Update()
    {
       if(PlayerPrefs.GetInt(gameObject.tag) == 1){
           gameObject.SetActive(false);
       }
    }
}
