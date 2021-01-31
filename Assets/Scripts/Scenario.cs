using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scenario : MonoBehaviour
{
    [SerializeField] public GameObject scenarioTitle;
    [SerializeField] public GameObject scenarioStatus;
    [SerializeField] private string scenarioId;
    [SerializeField] private string scenarioName;
    void Update()
    {
        Debug.Log(PlayerPrefs.HasKey(scenarioId));
        Debug.Log(PlayerPrefs.GetString(scenarioId));
        if (PlayerPrefs.HasKey(scenarioId)) {
            scenarioTitle.GetComponent<Text>().text = scenarioName;
        } else {
            scenarioTitle.GetComponent<Text>().text = "???";
        }

        if (!PlayerPrefs.HasKey(scenarioId)) {
            scenarioStatus.GetComponent<Text>().text = "";
        } else if (PlayerPrefs.GetString(scenarioId) == "SUCCESS") {
            scenarioStatus.GetComponent<Text>().text = "Complete";
        } else if (PlayerPrefs.GetString(scenarioId) == "FAILED") {
            scenarioStatus.GetComponent<Text>().text = "Failed";
        } else {
            scenarioStatus.GetComponent<Text>().text = "In Progress";
        }
    }
}
