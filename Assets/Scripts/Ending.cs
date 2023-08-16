using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject AmmoCanvas;

    public AudioSource music;
    public AudioSource creditsMusic;

    void Start()
    {
        Invoke("PlayCredits", 7);
    }

    void PlayCredits()
    {
        Canvas.SetActive(true);
        AmmoCanvas.SetActive(false);
        music.Stop();
        creditsMusic.Play();

        Invoke("EndGame", 7);
    }

    void EndGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
