using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public RectTransform healthBarRect;
    public int maxHealth;
    void Start ()
    {
        if(!PlayerPrefs.HasKey("SHIELD_COUNT")){
            PlayerPrefs.SetInt("SHIELD_COUNT", 4);
        }
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("SHIELD_COUNT") < 1){
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -0.3f, gameObject.transform.position.z);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("ON ENTER!");
        if(collider.gameObject.tag == "Shot")
        {
            Debug.Log("BOSS SHOT!");
            //nDestroy shot
            Destroy(collider.gameObject);

            Debug.Log(healthBarRect.sizeDelta);
            healthBarRect.sizeDelta = new Vector2(healthBarRect.sizeDelta.x - 1, healthBarRect.sizeDelta.y);
            healthBarRect.localPosition = new Vector3(healthBarRect.localPosition.x + 0.5f, healthBarRect.localPosition.y, healthBarRect.localPosition.z);
        }
    }
}