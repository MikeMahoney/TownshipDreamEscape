using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatPlatform : MonoBehaviour
{
    public AudioSource flute;
    public AudioSource music;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            flute.Play();
            music.Stop();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            flute.Stop();
            music.Play();
        }
    }
}
