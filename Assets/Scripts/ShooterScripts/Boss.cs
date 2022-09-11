using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public RectTransform healthBarRect;
    public GameObject shot;

    void Start ()
    {
        if(!PlayerPrefs.HasKey("SHIELD_COUNT")){
            PlayerPrefs.SetInt("SHIELD_COUNT", 4);
        }
        InvokeRepeating("CreateShot", 2, 0.5f);
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

            if(healthBarRect.sizeDelta.x <= 0){
                PlayerPrefs.SetString("KILLHENWEN", "SUCCESS");
                SceneManager.LoadScene(10);
            }
        }
    }
    void CreateShot()
    {
        if (healthBarRect.sizeDelta.x > 0) {
            int randomZ = Random.Range(-8, 8);
            Vector3 shotPosition = new Vector3(transform.position.x, shot.transform.position.y, transform.position.z-randomZ);
            GameObject clone = Instantiate(shot, shotPosition, shot.transform.rotation) as GameObject;
        } else {
            CancelInvoke();
        }
    }
}