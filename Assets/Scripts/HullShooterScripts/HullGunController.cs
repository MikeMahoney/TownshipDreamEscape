using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HullGunController : MonoBehaviour
{
    public float speed;
    public float tilt;

    public GameObject shot;
    public float fireRate;

    private float nextFire;

    private float yValue = 0;

    void Update ()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space) == true)
        {
            nextFire = Time.time + fireRate;
            shot.transform.eulerAngles = new Vector3 (90f, yValue, 0.0f);
            GameObject clone = Instantiate(shot, transform.position, shot.transform.rotation) as GameObject;
        }
    }

    void FixedUpdate ()
    {
        if(Input.GetKey(KeyCode.W) == true && yValue >= -40) {
            yValue -= 1;
            GetComponent<Transform>().eulerAngles = new Vector3 (0.0f, yValue, 0.0f);
        }
        if(Input.GetKey(KeyCode.S) == true && yValue <= 40) {
            yValue += 1;
            GetComponent<Transform>().eulerAngles = new Vector3 (0.0f, yValue, 0.0f);
        }
    }
}
