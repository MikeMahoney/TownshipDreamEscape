using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Shot")
        {
            Debug.Log("BARRIER HIT!");
            Destroy(collider.gameObject);
        }

        if(collider.gameObject.tag == "SoundBlast")
        {
            Debug.Log("SOUNDBLAST HIT!");
            PlayerPrefs.SetString("BarrierState", "DESTROYED");
            gameObject.SetActive(false);
        }
    }
}