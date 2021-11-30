using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("COLLIDED");
        if(collider.gameObject.tag == "Shot")
        {
            Debug.Log(gameObject.transform.parent.gameObject.name);
            int currentMoney = PlayerPrefs.GetInt("Money");

            if (gameObject.transform.parent.gameObject.name == "EnemyBasic(Clone)") {
                PlayerPrefs.SetInt("Money", currentMoney+5);
            } else if(gameObject.transform.parent.gameObject.name == "EnemySpecial(Clone)") {
                PlayerPrefs.SetInt("Money", currentMoney+10);
            }

            Destroy(gameObject.transform.parent.gameObject);
            Destroy(collider.gameObject);
        }
    }
}
