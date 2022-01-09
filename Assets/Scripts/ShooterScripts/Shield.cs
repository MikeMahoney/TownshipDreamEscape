using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int health;
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("ON ENTER!");
        if(collider.gameObject.tag == "Shot")
        {
            Destroy(collider.gameObject);
            health -= 1;
            if (health == 0) {
                destroyShield();
            }
        }
    }
 
    public void destroyShield()
    {
        gameObject.SetActive(false);
        PlayerPrefs.SetInt("SHIELD_COUNT", PlayerPrefs.GetInt("SHIELD_COUNT") - 1);
    }
}