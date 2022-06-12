using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    public RectTransform healthBarRect;
    public GameObject shot;
    public GameObject soundBlast;
    public float fireRate;

    private float nextFire;

    void Start ()
    {
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
            Debug.Log("PLAYER HIT!");
            Destroy(collider.gameObject);
            healthBarRect.sizeDelta = new Vector2(healthBarRect.sizeDelta.x - 8, healthBarRect.sizeDelta.y);
            healthBarRect.localPosition = new Vector3(healthBarRect.localPosition.x - 13, healthBarRect.localPosition.y, healthBarRect.localPosition.z);
            if (healthBarRect.sizeDelta.x <= 0) {
                SceneManager.LoadScene(1);
            }
            Debug.Log(healthBarRect.sizeDelta.x);
        }
    }
}
