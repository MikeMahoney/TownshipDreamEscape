using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeConsole : MonoBehaviour
{
    public string fruit = "";
    public void SetConsoleSuccess() {
        PlayerPrefs.SetString(fruit, "SUCCESS");
    }

    public void SetConsoleFailed() {
        SceneManager.LoadScene(10);
    }
}
