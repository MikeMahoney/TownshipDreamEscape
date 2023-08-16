using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public Text bossHealthUI;
    public int bossHealth = 100;
    public GameObject shot;
    public AudioSource hitSound;
    [SerializeField] private Material originalMaterial;
    [SerializeField] private Material flashMaterial;

    void Start ()
    {
        // PlayerPrefs.SetString("GUNMAN", "SUCCESS");
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
        if(collider.gameObject.tag == "Shot")
        {
            //Destroy shot
            Destroy(collider.gameObject);

            hitSound.Play();

            FlashColor();

            bossHealth = bossHealth - 5;
            bossHealthUI.text = bossHealth.ToString();

            if(bossHealth <= 0){
                PlayerPrefs.SetString("KILLHENWEN", "SUCCESS");
                SceneManager.LoadScene(10);
            }
        }
    }
    void CreateShot()
    {
        if (bossHealth > 0) {
            int randomZ = Random.Range(-8, 8);
            Vector3 shotPosition = new Vector3(transform.position.x, shot.transform.position.y, transform.position.z-randomZ);
            GameObject clone = Instantiate(shot, shotPosition, shot.transform.rotation) as GameObject;
        } else {
            CancelInvoke();
        }
    }

    void FlashColor()
    {
        GameObject.Find("default").GetComponent<Renderer>().material = flashMaterial;
        Invoke("ResetColor", 0.2f);
    }
    void ResetColor()
    {
        GameObject.Find("defaultBody").GetComponent<Renderer>().material = originalMaterial;
    }
}