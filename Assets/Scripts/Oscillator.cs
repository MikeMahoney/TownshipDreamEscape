using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float timeCount = 0;
    Vector3 startPos;

    float speed;
    float width;
    float height;
    void Start()
    {
        speed = 0.7f;
        width = 14;
        height = 14;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime*speed;

        float x = startPos.x + (Mathf.Cos(timeCount)*width);
        float y = startPos.y+ (Mathf.Sin(timeCount)*height);
        float z = startPos.z;

        transform.position = new Vector3(x, y, z);
    }
}
