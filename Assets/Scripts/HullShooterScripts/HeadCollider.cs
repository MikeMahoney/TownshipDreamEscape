using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollider : MonoBehaviour
{
    public AudioSource hitSound;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Shot")
        {
            int currentMoney = PlayerPrefs.GetInt("Money");

            Debug.Log(gameObject.transform.parent.gameObject.name);

            if (gameObject.transform.parent.gameObject.name == "EnemyBasic(Clone)") {
                PlayerPrefs.SetInt("Money", currentMoney+5);
            } else if(gameObject.transform.parent.gameObject.name == "EnemyGold(Clone)") {
                PlayerPrefs.SetInt("Money", currentMoney+10);
            }

            hitSound.Play();

            Invoke("DestroyEnemy", 0.5f);
        }
    }

    void DestroyEnemy()
    {
        Destroy(gameObject.transform.parent.gameObject);
        Destroy(GetComponent<Collider>().gameObject);
    }
}
