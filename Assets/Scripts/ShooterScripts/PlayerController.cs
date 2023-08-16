using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;

    public Text playerHealthUI;
    public int playerHealth = 100;
    public GameObject shot;
    public GameObject soundBlast;
    public float fireRate;

    private float nextFire;

    [SerializeField] private Material originalMaterial;
    [SerializeField] private Material flashMaterial;

    void Start ()
    {
        // PlayerPrefs.SetString("BANDWOMAN", "SUCCESS");
        // PlayerPrefs.SetString("GUNMAN", "SUCCESS");  

        if (
            PlayerPrefs.GetString("BANDWOMAN") == "SUCCESS"
        ){
            soundBlast.SetActive(true);
        }
    }

    void Update ()
    {
        if (
            PlayerPrefs.GetString("GUNMAN") == "SUCCESS" &&
            Input.GetButton("Fire1") &&
            Time.time > nextFire
        ){
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(shot, transform.position, shot.transform.rotation) as GameObject;
        }

        if(Input.GetKeyDown(KeyCode.Escape) == true) {
            SceneManager.LoadScene(1);
        }
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        float boundaryMax = boundary.xMax;

        // if(PlayerPrefs.GetString("BarrierState") == "DESTROYED"){
        //     boundaryMax = 40;
        // }

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3 
        (
            Mathf.Clamp (GetComponent<Rigidbody>().position.x, boundary.xMin, boundaryMax), 
            0.0f, 
            Mathf.Clamp (GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
        );
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "BossShot")
        {
            FlashColor();

            playerHealth = playerHealth - 10;
            playerHealthUI.text = playerHealth.ToString();

            Destroy(collider.gameObject);

            if (playerHealth <= 0) {
                SceneManager.LoadScene(10);
            }
        }
    }

    void FlashColor()
    {
        GameObject.Find("townModel").GetComponent<Renderer>().material = flashMaterial;
        Invoke("ResetColor", 0.2f);
    }
    void ResetColor()
    {
        GameObject.Find("townModel").GetComponent<Renderer>().material = originalMaterial;
    }
}
