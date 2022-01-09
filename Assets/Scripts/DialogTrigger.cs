using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    [SerializeField] private string scenarioId;
    [SerializeField] private string itemName;

    public void TriggerDialog () {
        string scenarioStatus = "";
        if (!PlayerPrefs.HasKey(scenarioId) && PlayerPrefs.GetString(itemName) != "SET") {
            PlayerPrefs.SetString(scenarioId, "STARTED");
        } else {
            if (!PlayerPrefs.HasKey(scenarioId)) {
                PlayerPrefs.SetString(scenarioId, "STARTED");
            }

            if(PlayerPrefs.GetString(itemName) == "SET"){
                scenarioStatus = "SUCCESS";
            } else {
                scenarioStatus = PlayerPrefs.GetString(scenarioId);
            }
        }
        FindObjectOfType<DialogManager>().StartDialog(dialog, scenarioStatus);
    }
}
