using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSetItem : MonoBehaviour
{
    [SerializeField] private string setItem = "";
    
    void Update()
    {
        if(PlayerPrefs.GetString(setItem) == "SET") {
            gameObject.SetActive(true);
        }
    }
}
