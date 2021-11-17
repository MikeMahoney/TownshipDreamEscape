using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullShot : MonoBehaviour
{
    public float speed;

    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    void Update ()
    {
        Debug.Log(transform.position.y);
        transform.position = new Vector3 (
            transform.position.x + speed,
            transform.position.y,
            (transform.position.z + (transform.rotation.z*0.6f))
        );
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
