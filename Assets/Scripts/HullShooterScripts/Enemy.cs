using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    void Update ()
    {
        transform.position = new Vector3 (
            transform.position.x - speed,
            transform.position.y,
            transform.position.z
        );
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }
}
