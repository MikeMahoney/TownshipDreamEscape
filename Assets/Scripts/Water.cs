using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Water : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("PLAYER ENTERED");
        if(collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(10);
        }
    }
}