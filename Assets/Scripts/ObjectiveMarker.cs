using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveMarker : MonoBehaviour
{
    [SerializeField] private string connectedItem = "";
    [SerializeField] private string scenarioId;
    [SerializeField] public GameObject setModel;
    void Update()
    {
        if(PlayerPrefs.GetString(connectedItem) == "SET") {
            gameObject.SetActive(false);
            setModel.SetActive(true);
        }

        if(PlayerPrefs.GetString(scenarioId) == "SUCCESS" || PlayerPrefs.GetString(scenarioId) == "FAILED") {
            gameObject.SetActive(false);
        }
    }
}
