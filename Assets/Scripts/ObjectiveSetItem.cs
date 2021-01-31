using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveSetItem : MonoBehaviour
{
    [SerializeField] private string setItem = "";
    void Update()
    {
        Debug.Log("SET ITEM!");
        Debug.Log(PlayerPrefs.GetString(setItem));
        if(PlayerPrefs.GetString(setItem) == "SET") {
            Debug.Log("IS SET");
            gameObject.SetActive(true);
        }
    }
}
