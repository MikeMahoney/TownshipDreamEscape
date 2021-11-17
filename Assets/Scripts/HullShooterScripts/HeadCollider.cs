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
            Debug.Log("ENEMY HIT!");
            Destroy(gameObject.transform.parent.gameObject);
            Destroy(collider.gameObject);
        }
    }
}
