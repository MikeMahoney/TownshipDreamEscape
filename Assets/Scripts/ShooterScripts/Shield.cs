using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("ON ENTER!");
        if(collider.gameObject.tag == "Shot")
        {
            Debug.Log("SHIELD HIT!");
        }
    }
 
    // void OnTriggerExit(Collider collider)
    // {
        
    // }
}